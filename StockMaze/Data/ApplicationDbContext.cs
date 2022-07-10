using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockMaze.Models;

namespace StockMaze.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StockMaze.Models.Product> product { get; set; }
        public DbSet<StockMaze.Models.Customer> Customer { get; set; }
        public DbSet<StockMaze.Models.Vendor> Vendor { get; set; }
        public DbSet<StockMaze.Models.Transaction> Transaction { get; set; }
    }
}