
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SecondModel
{
   public class SecondDbContext:DbContext
    {
        string database = "";
        public SecondDbContext() { }

    public SecondDbContext(DbContextOptions<SecondDbContext> options)
         : base(options)
    {
    }

        public SecondDbContext(string connectionDb) 

        {
            database = connectionDb;
        }

        public virtual DbSet<Question> Questions { get; set; }


        public static readonly ILoggerFactory CustomerLoggerFactory
    = LoggerFactory.Create(builder =>
    {
           /* builder
                 .AddFilter((category, level) =>
                     category == DbLoggerCategory.Database.Command.Name
                     && level == LogLevel.Information)
                 .AddDebug();*/
    });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
              
           // optionsBuilder.UseSqlServer("***********************************");
        }
        base.OnConfiguring(optionsBuilder.UseLoggerFactory(CustomerLoggerFactory));
        base.OnConfiguring(optionsBuilder);
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

        modelBuilder.Entity<Question>().HasData(new Question() { Id = 1, ColumnName =  "test" });
   

            base.OnModelCreating(modelBuilder);
    }
    //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}
