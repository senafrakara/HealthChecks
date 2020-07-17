using System;
using System.Collections.Generic;
using System.Text;
using HealthChecks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthChecks.Data
{
    public class ApplicationDbContext : IdentityDbContext<User> //by the way, the User model which isnot created by application side, can be used for all User operations. 
        //the User model is inherited from IdentityUser
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<URL> URLs { get; set; }
        public DbSet<Email> Emails { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<URL_EMAIL> URL_EMAILs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<URL_EMAIL>()
                .HasKey(u => new
                {
                    u.Url,
                    u.EmailAddress
                }); //in this case, the attributes(_URL and _EmailAddress in the URL_EMAIL table) set as a primary key, compound key

            modelBuilder.Entity<URL_EMAIL>()
                .HasOne(ue => ue.Email)
                .WithMany(e => e.URL_EMAIL_LIST)
                .HasForeignKey(u => u.EmailAddress); //in these cases, the attributes EmailAddress and Url set as foreign keys of URL_EMAIL table

            modelBuilder.Entity<URL_EMAIL>()
            .HasOne(ue => ue.URL)
            .WithMany(e => e.URL_EMAIL_LIST)
            .HasForeignKey(u => u.Url);

        }


    }

}
