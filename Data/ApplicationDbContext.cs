using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickCV.Data.DataModels;

namespace QuickCV.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<JobDetailsDataSet> JobDetails { get; set; }
        public DbSet<PersonalDetailsDataSet> PersonalDetails { get; set; }
    }
}
