using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using PropertyDealing.DataAccess;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

namespace PropertyDealing
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(PropertyDealingDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login/Index")
            });

        }
    }
}
