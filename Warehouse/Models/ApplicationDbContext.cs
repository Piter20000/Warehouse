using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Warehouse.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<SteelProfile> SteelProfiles { get; set; }

        public DbSet<ProfileDetails> ProfileDetails { get; set; }

        public DbSet<ProjectInformations> ProjectInformations { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<ProfileHistory> ProfileHistories { get; set; }
    }
}