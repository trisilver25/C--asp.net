using BasicMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer{

    public class AuthDBContext : IdentityDbContext<MVCUser>
    {
        public DbSet<MVCUser> MVCUsers {get; set;}
        public DbSet<Post> Posts {get; set;}

        public DbSet<Comment> Comments { get; set; }
        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder model) 
        {
            base.OnModelCreating(model);
        }
    }
}