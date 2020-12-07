using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Core.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TA_User> TA_Users { get; set; }
        public DbSet<SA_Tenant> SA_Tenants { get; set; }
        public DbSet<SA_User> SA_Users { get; set; }
    }
}
