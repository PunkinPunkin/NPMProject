using System;
using DAL.DB;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class NPMContext : DbContext
    {
        private string _connectionString;
        public NPMContext() : base() { }
        public NPMContext(string connectionString) : base() { _connectionString = connectionString; }
        public NPMContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<OrgInfo> OrgInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MyDB;Persist Security Info=True;Integrated Security=True;";
                }
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }

}
