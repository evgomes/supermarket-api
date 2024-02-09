namespace Supermarket.API.Resources
{
    public record ProductResource
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required int QuantityInPackage { get; init; }
        public required string UnitOfMeasurement { get; init; }
        public CategoryResource? Category { get; init; }
    }
}