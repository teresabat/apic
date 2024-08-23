using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apic.Models;
using Microsoft.EntityFrameworkCore;

namespace apic.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<User> Users{ get; set; }
    }
}