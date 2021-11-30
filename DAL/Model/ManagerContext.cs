using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class ManagerContext : DbContext
    {
        //enable-migrations -ContextTypeName DAL.Model.ManagerContext -MigrationsDirectory Migrations
        //Add-Migration ProjectQuestionCreate -Context ManagerContext -OutputDir Migrations
        //update-database -Context ManagerContext
        //remove-migration -context ManagerContext
        public ManagerContext()
        { }

        public ManagerContext(DbContextOptions<ManagerContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public virtual DbSet<Periot> Periots { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionHorizontal> QuestionHorizontals { get; set; }
        public virtual DbSet<QuestionVertical> QuestionVerticals { get; set; }
        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Jop> Jops { get; set; }

        public virtual DbSet<Aim> Aims { get; set; }
        public virtual DbSet<Target> Targets { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<SubAction> SubActions{ get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<PerformancePeriot> PerformancePeriots { get; set; }
        public virtual DbSet<PerformanceAim> PerformanceAims { get; set; }
        public virtual DbSet<Performance_Target_Result> Performance_Target_Results { get; set; }
        public virtual DbSet<PerformanceType> PerformanceTypes { get; set; }

        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Match> Matchs { get; set; }
        public virtual DbSet<PerformanceMatchTarget> PerformanceMatchTargets { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                         // optionsBuilder.UseSqlServer("Data Source= DESKTOP-FSJ8JLM\\SQLEXPRESS;Initial Catalog=ManagerDb;User ID=sa;Password=nasah;MultipleActiveResultSets=True");
                   optionsBuilder.UseSqlServer("Server=89.252.181.210\\MSSQLSERVER2019;Database=arastirma_ManagerDb;User Id=arastirma_service;Password=AraTara05*;MultipleActiveResultSets=True");
            }
            base.OnConfiguring(optionsBuilder.UseLoggerFactory(CustomerLoggerFactory));
            base.OnConfiguring(optionsBuilder);
        }

         public static readonly ILoggerFactory CustomerLoggerFactory= LoggerFactory.Create(builder =>
         {
             builder
                 .AddFilter((category, level) =>
                     category == DbLoggerCategory.Database.Command.Name
                     && level == LogLevel.Information)
                 .AddDebug();
         });



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("S1425p", out passwordHash, out passwordSalt);
            var user = new User
            {
                Id = 1,
                UserName= "admin@arastirmaturk.com",
                Email = "admin@arastirmaturk.com",
                FirstName = "Admin",
                LastName = "Admin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            modelBuilder.Entity<Branch>().HasData(new Branch { Id=1,Explanation="IT"});
            modelBuilder.Entity<OperationClaim>().HasData(new OperationClaim { Id = 1, Name = "Admin" });
            modelBuilder.Entity<User>().HasData(user);
            
            modelBuilder.Entity<UserOperationClaim>().HasData(new UserOperationClaim { Id = 1, UserId = 1, OperationClaimId = 1 });
            modelBuilder.Entity<Match>().HasData(new Match { Id = 1, Explanation = "Hedef" });
            modelBuilder.Entity<Match>().HasData(new Match { Id = 2, Explanation = "Faaliyet" });
            modelBuilder.Entity<Match>().HasData(new Match { Id = 3, Explanation = "Alt Faaliyet" });
            modelBuilder.Entity<PerformanceAim>().HasData(new PerformanceAim { Id = 1, Explanation = "Yüzdesel Artış" });
            modelBuilder.Entity<PerformanceAim>().HasData(new PerformanceAim { Id = 2, Explanation = "Rakamsal Artış" });
            modelBuilder.Entity<PerformanceAim>().HasData(new PerformanceAim { Id = 3, Explanation = "Eşit" });
            modelBuilder.Entity<PerformanceAim>().HasData(new PerformanceAim { Id = 4, Explanation = "Rakamsal Azalış" });
            modelBuilder.Entity<PerformanceAim>().HasData(new PerformanceAim { Id = 5, Explanation = "Yüzdesel Artış" });
            
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 1, Explanation =  1 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 2, Explanation =  2 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 3, Explanation =  3 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 4, Explanation =  4 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 5, Explanation =  5 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 6, Explanation =  6 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 7, Explanation =  7 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 8, Explanation =  8 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 9, Explanation = 9 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 10, Explanation = 10 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 11, Explanation = 11 });
            modelBuilder.Entity<PerformancePeriot>().HasData(new PerformancePeriot { Id = 12, Explanation = 12 });

            modelBuilder.Entity<PerformanceType>().HasData(new PerformanceType { Id = 1, Explanation = "kg" });
            modelBuilder.Entity<PerformanceType>().HasData(new PerformanceType { Id = 2, Explanation = "m2" });
            modelBuilder.Entity<PerformanceType>().HasData(new PerformanceType { Id = 3, Explanation = "m3" });


            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName).HasMaxLength(100);
                entity.Property(e => e.PasswordHash).HasMaxLength(100);
                entity.Property(e => e.Telephone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsUsing).HasDefaultValue(false);
                entity.Property(e => e.Token).HasMaxLength(255);
            });
            
            modelBuilder.Entity<PerformanceMatchTarget>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Aim>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(500);

            });


            modelBuilder.Entity<Target>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(700);

            });



            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(700);

            });

            modelBuilder.Entity<SubAction>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(700);

            });

            modelBuilder.Entity<Performance>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(250);
                entity.Property(e => e.TargetValue).HasColumnType("decimal(18,4)");
                entity.Property(e => e.BaseValue).HasColumnType("decimal(18,4)");

            });

            modelBuilder.Entity<PerformancePeriot>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(50);

            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.Explanation).HasMaxLength(100);

            });

            modelBuilder.Entity<Performance_Target_Result>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Target).HasColumnType("decimal(18,4)");
                entity.Property(e => e.Result).HasColumnType("decimal(18,4)");

            });

            modelBuilder.Entity<PerformanceType>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Explanation).HasMaxLength(150);
            });

            modelBuilder.Entity<Match>(entity =>
            {
   
                entity.Property(e => e.Explanation).HasMaxLength(150);

            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Guid).HasMaxLength(100);
                entity.Property(e => e.InsertTime).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IsSuccess).HasDefaultValue(false);
                entity.Property(e => e.SuccesCount).HasDefaultValue(0);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(70);
                entity.Property(e => e.Text).HasMaxLength(1000);
                entity.Property(e => e.Type).HasMaxLength(100);
                


            });

            modelBuilder.Entity<QuestionHorizontal>(entity =>
            {
                entity.Property(e => e.ColumnName).HasMaxLength(70);
                entity.Property(e => e.Text).HasMaxLength(1000);

            });


        

            modelBuilder.Entity<SurveyStatu>(entity =>
            {
                entity.Property(e => e.Statu).HasMaxLength(150);
                

            });

            modelBuilder.Entity<Jop>(entity =>
            {
                entity.Property(e => e.Explanation).HasMaxLength(150);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.Explanation).HasMaxLength(150);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Explanation).HasMaxLength(150);
            });

            modelBuilder.Entity<QuestionVertical>(entity =>
            {
                entity.Property(e => e.ColumnName).HasMaxLength(70);
                entity.Property(e => e.Text).HasMaxLength(1000);
                entity.Property(e => e.Point).HasPrecision(9, 4);
                entity.Property(e => e.IsOpen).HasDefaultValue(false);
            });


            modelBuilder.Entity<OperationClaim>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Periot>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });
            base.OnModelCreating(modelBuilder);
        }
        //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
