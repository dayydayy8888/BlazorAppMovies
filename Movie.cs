using System.ComponentModel.DataAnnotations;

namespace BlazorApp1
{
	public class Movie
	{
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		public DateOnly? ReleaseDate { get; set; }

		public string? Genre { get; set; }
		[Range(1, 100)]
		public decimal Price { get; set; }
	}
}
