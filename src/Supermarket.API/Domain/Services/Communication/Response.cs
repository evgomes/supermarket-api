namespace Supermarket.API.Domain.Services.Communication
{
    public record Response<T>
    {
        public bool Success { get; init; }
        public string? Message { get; init; }
        public T? Resource { get; init; }

        public Response(T resource)
        {
            Success = true;
            Message = null;
            Resource = resource;
        }

		public Response(string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }
    }
}