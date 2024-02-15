using Microsoft.AspNetCore.Identity;

namespace booklish.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int BooksId { get; set; }
        public virtual Books? Books { get; set; }

        public string status {  get; set; }
        public DateTime date {  get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
