namespace Supermarket.API.Persistence.Contexts
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            var products = new List<Product>
            {
                new() {
                    Id = 100,
                    Name = "Apple",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = UnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new() {
                    Id = 101,
                    Name = "Milk",
                    QuantityInPackage = 2,
                    UnitOfMeasurement = UnitOfMeasurement.Liter,
                    CategoryId = 101,
                }
            };

            var categories = new List<Category>
            {
                new() { Id = 100, Name = "Fruits and Vegetables" }, // Id set manually due to in-memory provider
                new() { Id = 101, Name = "Dairy" }
            };

            context.Products.AddRange(products);
            context.Categories.AddRange(categories);

            await context.SaveChangesAsync();
        }
    }
}