using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingUI.Models;

namespace OnlineShoppingUI.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<HistoryRecord> HistoryRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=history.db"); // Veritabanı dosyası
        }
    }
}
