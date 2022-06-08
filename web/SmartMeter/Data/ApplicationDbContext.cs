using Microsoft.EntityFrameworkCore;
using SmartMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMeter.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Signup> Signup { get; set; }
    }
}
