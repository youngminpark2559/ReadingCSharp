using Microsoft.EntityFrameworkCore;

//c Add ApplicationDbContext.cs in Models folder.

namespace PartyInvites.Models 
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext() {}
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlite("Filename=./PartyInvites.db");
        }
        public DbSet<GuestResponse> Invites {get; set;}
    }
}