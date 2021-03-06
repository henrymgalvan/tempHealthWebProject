﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthWebApp.Models;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Models.Person;
using HealthWebApp.Models.HouseholdProfile;
using HealthWebApp.Models.HouseholdMember;
using HealthWebApp.Data.EntityModel.Barangays;
using HealthWebApp.Data.EntityModel.Household;

namespace HealthWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People {get; set;}
        public DbSet<Religion> Religion {get; set;}
        public DbSet<Work> Work {get; set;}
        public DbSet<Education> Education {get; set;} //Highest Educational Attainment 
        public DbSet<Barangay> Barangay { get; set; }
        public DbSet<CityMunicipality> City { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<PhilArea> PhilArea { get; set; }

        public DbSet<HouseholdMember> HouseholdMember { get; set; }
        public DbSet<HouseholdProfile> HouseholdProfile { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
