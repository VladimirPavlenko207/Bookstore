using Bookstore.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class BookStoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionPeriod> PromotionPeriods { get; set; } 
        public DbSet<Book> Books { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderItem> OrderItems { get; set; }

        public BookStoreContext() 
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        } 

        public void CreateTestData()
        {
            TestDataCreator.CreateData(this);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=bookstoreDb;User ID=user1;Password=qwerty;");
        }
    }
}
