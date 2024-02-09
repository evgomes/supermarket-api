namespace Supermarket.API.Resources
{
    public record CategoryResource
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}