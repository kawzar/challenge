using Challenge.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Data.Context
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options)
            : base(options)
        { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }

}
