using Microsoft.AspNetCore.Identity;

namespace booklish.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
