
using Database.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookTest.Data
{
    public class DBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        /// <summary>
        /// DB path (Data base location)
        /// </summary>
        public string DbPath { get; private set; }

        public DBContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}SalesDB.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
