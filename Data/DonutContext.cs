using HoodooDonuts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodooDonuts.Data
{
    public class DonutContext : DbContext
    {
        public DonutContext(DbContextOptions<DonutContext> options) : base(options)
        {

        }
        
        public DbSet<Donut> Donut { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
