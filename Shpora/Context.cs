using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shpora.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Shpora
{
    public class Context : DbContext
    {
        private string _connectionString = "Data Source=DESKTOP-HIITB3O; initial Catalog=test;Integrated Security=True;TrustServerCertificate=True";

        public DbSet<User> test { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public Context()
        {

        }
    }
}
