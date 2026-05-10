using Microsoft.EntityFrameworkCore;
using MvcUsersProject.Models;

namespace MvcUsersProject.Data
{
    public class ApplictionDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MvcUsersProjectDb;Trusted_Connection=True;");

        }
    }
}
