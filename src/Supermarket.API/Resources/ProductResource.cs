namespace Supermarket.API.Resources
{
	public record ProductResource
	{
		public int Id { get; init; }
		public string Name { get; init; } = null!;
		public int QuantityInPackage { get; init; }
		public string UnitOfMeasurement { get; init; } = null!;
		public CategoryResource? Category { get; init; }
	}
}