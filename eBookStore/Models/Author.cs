using System.Text.Json.Serialization;

namespace eBookStore.Models
{
	public class Author
	{
		[JsonPropertyName("authorId")]
		public int AuthorId { get; set; }
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
