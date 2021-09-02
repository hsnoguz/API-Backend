using Bussines.Abstract;
using Bussines.Concrete;
using Core.DependencyResolvers;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encyption;
using Core.Utilities.Security.JWT;

using Core.Extensions;

using DAL.Abstract;
using DAL.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repository;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.SecondModel;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using Service.Abstract;

namespace TemelService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ManagerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ManagerConnection"), y => y.MigrationsAssembly("DAL")));
            //    services.AddDbContext<SecondDbContext>(options => options.UseSqlServer(y => y.MigrationsAssembly("DAL")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IEfListServiceDal<>), typeof(EfListServiceDal<>));
      //      services.AddTransient(typeof(IListService<>), typeof(ListService<>));
            services.AddControllersWithViews()
              .AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
          );
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize);
            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement, UnicodeRanges.LatinExtendedA }));

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
     

            /* services.AddTransient<IUserService, UserManager>();
             services.AddTransient<IUserDal, EfUserDal>();
             services.AddTransient<IAuthService, AuthManager>();
             services.AddTransient<ITokenHelper, JwtHelper>();*/

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
            services.AddDependencyResolvers(new ICoreModule[]
              {
                new CoreModule(),
              });

            //  services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TemelService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TemelService v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var serviceScope = serviceScopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<ManagerContext>();
                dbContext.Database.EnsureCreated();
            }


        //    app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-XSS-Protection", "1; mode=block ");
                context.Response.Headers.Add("Content-Security-Policy", "default-src 'self';");
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                await next.Invoke();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
