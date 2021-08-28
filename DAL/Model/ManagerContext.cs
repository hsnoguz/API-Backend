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

namespace DAL.Model
{
    public class ManagerContext : DbContext
    {
        //enable-migrations -ContextTypeName DAL.Model.ManagerContext -MigrationsDirectory Migrations
        //Add-Migration ProjectQuestionCreate -Context ManagerContext -OutputDir Migrations
        //update-database -Context ManagerContext
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
        public virtual DbSet<Organization> Organizations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ManagerDb;Integrated Security=SSPI;MultipleActiveResultSets=True");
            }
            base.OnConfiguring(optionsBuilder.UseLoggerFactory(CustomerLoggerFactory));
            base.OnConfiguring(optionsBuilder);
        }

        public static readonly ILoggerFactory CustomerLoggerFactory
       = LoggerFactory.Create(builder =>
       {
           /* builder
                 .AddFilter((category, level) =>
                     category == DbLoggerCategory.Database.Command.Name
                     && level == LogLevel.Information)
                 .AddDebug();*/
       });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("S1425p", out passwordHash, out passwordSalt);
            var user = new User
            {
                Id = 1,
                Email = "admin@arastirmaturk.com",
                FirstName = "Admin",
                LastName = "Admin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            modelBuilder.Entity<User>().HasData(user);
            // modelBuilder.Entity<OperationClaim>().HasData(new OperationClaim { Id = 1, Name = "Admin" });
            modelBuilder.Entity<UserOperationClaim>().HasData(new UserOperationClaim { Id = 1, UserId = 1, OperationClaimId = 1 });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName).HasMaxLength(100);
                entity.Property(e => e.PasswordHash).HasMaxLength(100);
                entity.Property(e => e.Telephone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.RefreshToken).HasMaxLength(255);

            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.InsertTime).HasDefaultValue(DateTime.Now);
                entity.Property(e => e.IsSuccess).HasDefaultValue(false);
                entity.Property(e => e.SuccesCount).HasDefaultValue(0);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.ColumnName).HasMaxLength(70);
                entity.Property(e => e.Text).HasMaxLength(1000);
                entity.Property(e => e.Type).HasMaxLength(100);
                entity.Property(e => e.ColumnName).HasMaxLength(70);


            });

            modelBuilder.Entity<QuestionHorizontal>(entity =>
            {
                entity.Property(e => e.ColumnName).HasMaxLength(70);
                entity.Property(e => e.Text).HasMaxLength(1000);

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
                entity.Property(e => e.Point).HasPrecision(9, 4); ;
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
