using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class ApplicationUser:IdentityUser
    {
        public int CartId { get; set; }

        //Nav Prop Right
        public Cart Cart { get; set; }
       
    }
}
