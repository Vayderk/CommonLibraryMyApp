using CommonLibraryMyApp.Types.Gallery;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibraryMyApp.ConnectionManager.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RHUFILG\MSSQLSERVER01;Initial Catalog=PhotosMyApp;Integrated Security=True;")
                .EnableSensitiveDataLogging(true);
        }

        public DbSet<PhotoApp> PhotosApp { get; set; }
    }
}
