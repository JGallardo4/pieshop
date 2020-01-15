using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace pieshop.Models
{
	public class AppDbContext : IdentityDbContext<IdentityUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{			
		}

		public DbSet<Pie> Pies { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed categories
			modelBuilder.Entity<Category>().HasData(new Category{CategoryId=1, CategoryName="Fungus Pies", Description="All fungus-based pies"});
			modelBuilder.Entity<Category>().HasData(new Category{CategoryId=2, CategoryName="Fruit Pies", Description="All pies made from alien fruits"});
			modelBuilder.Entity<Category>().HasData(new Category{CategoryId=3, CategoryName="Bean Pies", Description="Pies with bean fillings"});

			// Seed pies
			modelBuilder.Entity<Pie>().HasData(new Pie
			{PieId=1, Name="Brain Pie", Price=15.95M,
			ShortDescription="Made with false morel (Gyromitra esculenta)",
			LongDescription="",
			CategoryId=1,
			ImageUrl="/images/brain.jpg",
			InStock=true,
			IsPieOfTheWeek=false,
			ImageThumbnailUrl="",
			AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=2, Name="Bleeding Tooth Pie", Price=16.00M,
				ShortDescription="Made with Hydnellum pecki",
				LongDescription="",
				CategoryId=1,
				ImageUrl="/images/bleeding-tooth.jpg",
				InStock=true,
				IsPieOfTheWeek=true,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=3, Name="Glow Pie", Price=12.50M,
				ShortDescription="Made with bioluminiscent mushrooms",
				LongDescription="",
				CategoryId=1,
				ImageUrl="/images/glow.jpg",
				InStock=true,
				IsPieOfTheWeek=true,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=4, Name="Pepino Pie", Price=16.75M,
				ShortDescription="Made with Pepino Fruit from South America",
				LongDescription="",
				CategoryId=2,
				ImageUrl="/images/pepino.jpg",
				InStock=true,
				IsPieOfTheWeek=false,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=5, Name="Kumquat Pie", Price=14.25M,
				ShortDescription="Made with Kumquat Fruit from China",
				LongDescription="",
				CategoryId=2,
				ImageUrl="/images/kumquat.jpg",
				InStock=true,
				IsPieOfTheWeek=true,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=6, Name="Kiwano Pie", Price=15.75M,
				ShortDescription="Made with Kiwano Fruit from South Africa",
				LongDescription="",
				CategoryId=2,
				ImageUrl="/images/kiwano.jpg",
				InStock=true,
				IsPieOfTheWeek=false,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=7, Name="Navy Bean Pie", Price=13.99M,
				ShortDescription="With butter, chocolate, and vanilla",
				LongDescription="",
				CategoryId=3,
				ImageUrl="/images/bean.jpg",
				InStock=true,
				IsPieOfTheWeek=true,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=8, Name="Sweet Red Bean Pie", Price=14.50M,
				ShortDescription="Made with read beans",
				LongDescription="",
				CategoryId=3,
				ImageUrl="/images/red-bean.jpg",
				InStock=true,
				IsPieOfTheWeek=false,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});

			modelBuilder.Entity<Pie>().HasData(new Pie
			{
				PieId=9, Name="Edamame Pie", Price=16.25M,
				ShortDescription="Made with edamame beans, mozarella, and zucchini",
				LongDescription="",
				CategoryId=3,
				ImageUrl="/images/edamame.jpg",
				InStock=true,
				IsPieOfTheWeek=false,
				ImageThumbnailUrl="",
				AllergyInformation=""
			});
		}
  }
}