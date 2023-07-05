namespace Supermarket.API.Domain.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public short QuantityInPackage { get; set; }
		public UnitOfMeasurement UnitOfMeasurement { get; set; }

		public int CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}