using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetworkPrototype.DataLayer.Context;
using SocialNetworkPrototype.Models.Users;

namespace SocialNetworkPrototype.DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        /*public DbSet<Friend> Friends { get; set; }
        public DbSet<Message> Messages { get; set; }*/
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfuiguration());
        }
    }
}
