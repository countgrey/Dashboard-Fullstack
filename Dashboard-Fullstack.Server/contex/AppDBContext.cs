using Microsoft.EntityFrameworkCore;
using AngularAuthAPI.Models;
using Dashboard_Fullstack.Server.Models;

namespace AngularAuthAPI.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Data> Datas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=DashboardData;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}