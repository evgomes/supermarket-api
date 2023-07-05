namespace Supermarket.API.Resources
{
	public record ErrorResource
	{
		public bool Success => false;
		public List<string> Messages { get; private set; }

		public ErrorResource(List<string> messages)
		{
			Messages = messages ?? new();
		}

		public ErrorResource(string message)
		{
			Messages = new();

			if (!string.IsNullOrWhiteSpace(message))
			{
				this.Messages.Add(message);
			}
		}
	}
}