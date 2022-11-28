using System;
using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
	public class ShopContext : DbContext
	{
		public ShopContext(DbContextOptions<ShopContext> options): base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			//Define relationship between tables.
			modelBuilder.Entity<Category>()
				.HasMany(p => p.Products)
				.WithOne(c => c.Category)
				.HasForeignKey(c => c.CategoryId);

			modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}

