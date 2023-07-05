namespace Supermarket.API.Resources
{
    public record CategoryResource
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
    }
}