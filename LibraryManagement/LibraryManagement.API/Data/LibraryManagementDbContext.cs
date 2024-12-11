using LibraryManagement.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.API.Data
{
    public class LibraryManagementDbContext : DbContext
    {
        public LibraryManagementDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationships
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
