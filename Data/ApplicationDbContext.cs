using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp_FA_BSD_Training.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_FA_BSD_Training.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Session>().HasData
                (
                  new Session
                  {
                      Id = 1,
                      Title = "Intro to Web FA BSD training",
                      Date = new DateTime(2024, 1, 31),
                      Duration = 40,
                      Knowledge_Base = null,
                      Link_IT_help_ticket = null


                  }


                );
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}