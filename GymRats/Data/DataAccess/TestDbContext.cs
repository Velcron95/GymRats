using GymRats.Data.Models;
using GymRats.Data.Utilities;
using Microsoft.EntityFrameworkCore;
namespace GymRats.Data.DataAccess
{
    public class TestDbContext: DbContext
    {
        public DbSet<Ingredients> Ingredients { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionDb = $"Filename={PathDb.GetPath("test.db")}";
            optionsBuilder.UseSqlite(connectionDb);
        }
    }
}
