using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;


namespace PropertyDealing.DataAccess.Models
{
    public class User : IdentityUser
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public override string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
