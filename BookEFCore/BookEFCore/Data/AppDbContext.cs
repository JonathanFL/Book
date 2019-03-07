using System;
using System.Collections.Generic;
using System.Text;
using BookEFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookEFCore.Data
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBooks>().HasKey(ab => new {ab.BookIsbn, ab.firstName_FK, ab.lastName_FK});
            modelBuilder.Entity<AuthorBooks>()
                .HasOne(aurBook => aurBook.Book)
                .WithMany(books => books.Books)
                .HasForeignKey(b => b.BookIsbn);

            modelBuilder.Entity<AuthorBooks>()
                .HasOne(a => a.Author)
                .WithMany(a => a.Authors)
                .HasForeignKey(fk => new {fk.firstName_FK, fk.lastName_FK});
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
