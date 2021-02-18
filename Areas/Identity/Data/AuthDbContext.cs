using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILearnCoreV19.Areas.Identity.Data;
using ILearnCoreV19.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ILearnCoreV19.Data
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationMessage>()
               .HasOne<ApplicationUser>(a => a.Sender)
               .WithMany(d => d.Messages)
               .HasForeignKey(d => d.UserID);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> Users { get; set; } // Users from the database
        public DbSet<ApplicationEvent> Events { get; set; } // Events from the database
        public DbSet<ApplicationMessage> Messages { get; set; } // Messages from the database
        public DbSet<ApplicationNotif> Notif { get; set; } // Notif from the database
        public DbSet<ApplicationSubscription> Subscriptions { get; set; } // Subscriptions from the database
    }
}
