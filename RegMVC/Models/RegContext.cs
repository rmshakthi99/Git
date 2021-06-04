using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegMVC.Models
{
    public class RegContext:DbContext

    {
        public RegContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Registration> Registrations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().HasData(new Registration() {Id=1, Username = "navreen", Password = "nav123" });
        }

    }
}
