﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussines.Abstract;
using Bussines.Concrete;
using Bussines.Service.Abstract;
using Bussines.Service.Concrete;
using Castle.DynamicProxy;
using Core.Interceptors;
using Core.Utilities.Security.JWT;
using DAL.Abstract;
using Service.Abstract;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
    

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<RefreshTokenService>().As<IRefreshTokenService>();
            builder.RegisterType<EfRefreshTokenDal>().As<IEfRefreshTokenDal>();
            builder.RegisterType<EfPeriotDal>().As<IEfPeriotDal>();
            builder.RegisterType<EfAimDal>().As<IEfAimDal>();
            builder.RegisterType<EfActionDal>().As<IEfActionDal>();
            builder.RegisterType<EfSubActionDal>().As<IEfSubActionDal>();
            //      builder.RegisterType<EfTargetDal>().As<IEfAimDal>();
            builder.RegisterType<EfProjectDal>().As<IEfProjectDal>();
            builder.RegisterType<EfQuestionDal>().As<IEfQuestionDal>();
            builder.RegisterType<EfQuestionHorizontalDal>().As<IEfQuestionHorizontalDal>();
            builder.RegisterType<EfQuestionVerticalDal>().As<IEfQuestionVerticalDal>();
            builder.RegisterType<EfTargetDal>().As<IEfTargetDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<ProjectManager>().As<IProjectManager>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<PeriotManager>().As<IPeriotManager>();
            builder.RegisterType<BranchService>().As<IBranchService>();
            builder.RegisterType<JopService>().As<IJopService>();
            builder.RegisterType<SignPeriotManager>().As<ISignPeriot>();
            builder.RegisterType<OrganizationService>().As<IOrganizationService>();
            builder.RegisterType<AimManager>().As<IAimManager>();
            builder.RegisterType<TargetManager>().As<ITargetManager>();
            builder.RegisterType<ActionManager>().As<IActionManager>();
            builder.RegisterType<SubActionManager>().As<ISubActionManager>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();



    }
    }
}
