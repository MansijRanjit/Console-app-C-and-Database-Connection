using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppxyz.models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppxyz.data
{
    public class defaultcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MANSIJ\\SQLEXPRESS;Initial Catalog=xyz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Students> Student { get; set; }
    }
}