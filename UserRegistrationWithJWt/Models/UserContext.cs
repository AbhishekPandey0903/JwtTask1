using Microsoft.EntityFrameworkCore;

namespace UserRegistrationWithJWt.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<UserModel> JwTtable { get; set; }
    }
}
