using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ManagerContext : DbContext
    {

        public ManagerContext(DbContextOptions<ManagerContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ManagerDb;Integrated Security=SSPI;");
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
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName).HasMaxLength(100);
                entity.Property(e => e.Password).HasMaxLength(100);
                entity.Property(e => e.Telephone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
               entity.Property(e => e.InsertTime).HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });
                base.OnModelCreating(modelBuilder);
        }
      //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
