using Microsoft.EntityFrameworkCore;
using TravelerApi.DAL.Entities;

namespace TravelerApi.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GUNESBERKANT\\SQLEXPRESS;initial catalog=TravelerDbApi;integrated security=true;encrypt=false;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
