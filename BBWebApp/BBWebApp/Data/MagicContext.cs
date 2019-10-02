using BBWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BBWebApp.Data
{
    public class MagicContext : DbContext
    {
        private static string _connectionString;
        public MagicContext(DbContextOptions<MagicContext> options) : base(options)
        {

        }
        public DbSet<Genere> Generi { get; set; }
        public DbSet<Attore> Attori { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            optionsBuilder.UseSqlServer(_connectionString);
        }

        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                ;

            var configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}
