using Microsoft.EntityFrameworkCore;
using AngularAuthAPI.Models;

namespace AngularAuthAPI.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public string DbPath { get;}

        public AppDBContext()
        {
            DbPath = "database.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}