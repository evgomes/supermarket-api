using System.Collections.Generic;

namespace Supermarket.API.Resources
{
	public record QueryResultResource<T>
	{
		public int TotalItems { get; init; } = 0;
		public List<T> Items { get; init; } = new();
	}
}