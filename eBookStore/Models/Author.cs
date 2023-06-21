using System.Text.Json.Serialization;

namespace eBookStore.Models
{
	public class Author
	{
		[JsonPropertyName("lastName")]
		public string? LastName { get; set; }
		[JsonPropertyName("firstName")]
		public string? FirstName { get; set; }
		[JsonPropertyName("city")]
		public string? City { get; set; }
		[JsonPropertyName("emailAddress")]
		public string? EmailAddress { get; set; }

	}

}
