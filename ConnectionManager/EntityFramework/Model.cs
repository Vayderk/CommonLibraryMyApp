using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<PhotoMyApp> PhotosMyApp { get; set; }
        //public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=DESKTOP-RHUFILG\MSSQLSERVER01;Database=MyApp;Trusted_Connection=True;");
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.us(@"Data Source=DESKTOP-RHUFILG\MSSQLSERVER01;Initial Catalog=ContosoUniversity1;Integrated Security=SSPI;");
    }

    public class PhotoMyApp
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Who { get; set; }

    }

}