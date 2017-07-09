using System.Data.Entity;

namespace WebApplication1.Models.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}