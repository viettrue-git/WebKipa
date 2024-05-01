using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApp.Models
{
    public class WebContext : DbContext
    {
        public DbSet<Banner> banners { set; get; }        // bảng banner
        public DbSet<UserModel> users { set; get; }                // bảng user


        public WebContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //var config = _appsettings.Value.DefaultConnection;
        //    optionsBuilder.UseSqlServer(ConnectStrring);
        //    //optionsBuilder.UseLoggerFactory(GetLoggerFactory());       // bật logger
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>().ToTable("Banner");
            modelBuilder.Entity<UserModel>().ToTable("User");
        }
    }
}
