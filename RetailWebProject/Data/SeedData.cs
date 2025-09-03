using RetailWebProject.Models;

namespace RetailWebProject.Data
{
    public static class SeedData
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any() || context.Customers.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product
                {
                    Name = "iPhone 16 Pro Max",
                    Category = ProductCategory.Electronics,
                    Price = 1199.99m,
                    ReleaseDate = new DateTime(2024, 9, 20)
                },
                new Product
                {
                    Name = "Samsung Galaxy S25 Ultra",
                    Category = ProductCategory.Electronics,
                    Price = 1399.99m,
                    ReleaseDate = new DateTime(2025, 2, 15)
                },
                new Product
                {
                    Name = "PlayStation 6",
                    Category = ProductCategory.Electronics,
                    Price = 699.99m,
                    ReleaseDate = new DateTime(2024, 11, 12)
                },
                new Product
                {
                    Name = "Nike Air Zoom 2025",
                    Category = ProductCategory.Clothing,
                    Price = 199.99m,
                    ReleaseDate = new DateTime(2025, 3, 1)
                },
                new Product
                {
                    Name = "Organic Smart Coffee 2025",
                    Category = ProductCategory.Food,
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2025, 1, 10)
                },
                new Product
                {
                    Name = "Smart Home AI Assistant",
                    Category = ProductCategory.Home,
                    Price = 249.99m,
                    ReleaseDate = new DateTime(2025, 5, 5)
                },
                new Product
                {
                    Name = "Luxury Face Cream 2025 Edition",
                    Category = ProductCategory.Beauty,
                    Price = 99.99m,
                    ReleaseDate = new DateTime(2025, 4, 18)
                },
                new Product
                {
                    Name = "Tranquillo Special Edition",
                    Category = ProductCategory.Electronics,
                    Price = 1234.56m,
                    ReleaseDate = DateTime.Now
                }
            };

            context.Products.AddRange(products);

            var customers = new Customer[]
            {
                new Customer
                {
                    FullName = "Meme Houeibib",
                    Email = "meme.houeibib@estiam.com",
                    DateOfBirth = new DateTime(1996, 1, 1)
                },
                new Customer
                {
                    FullName = "Ayoub Mounadef",
                    Email = "ayoub.mounadef@estiam.com",
                    DateOfBirth = new DateTime(1996, 1, 1)
                },
                new Customer
                {
                    FullName = "Mouad Karroum",
                    Email = "mouad.karroum@estiam.com",
                    DateOfBirth = new DateTime(1996, 1, 1)
                }
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}
