namespace Supermarket.API.Resources
{
    public record QueryResource
    {
        public int Page { get; init; }
        public int ItemsPerPage { get; init; }
    }
}