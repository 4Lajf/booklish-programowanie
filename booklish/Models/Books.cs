using Microsoft.AspNetCore.Identity;

namespace booklish.Models
{
    public class Books
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Genre { get; set; }
		public int Price { get; set; }
		public string Img { get; set; }
		public string Description { get; set; }
	}
}
