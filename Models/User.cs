using Microsoft.AspNetCore.Identity;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public int Mail { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Password { get; set; }
    }
}