using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Areas.Identity.Data
{
    public class FlightsmeUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
