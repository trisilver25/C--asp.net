using BasicMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer{

    public class BasicDBContext : DbContext {
        
        public DbSet<Message> messages {get; set;} = null!;
        public BasicDBContext(DbContextOptions<BasicDBContext> options): base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message>().HasData(
                new Message {MessageID = 1, MessageText = "Message One"},
                new Message {MessageID = 2, MessageText = "Message Two"}
            );

        }

    }
}