using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CognitoDemo.Controllers
{
    public class AccountController : Controller
    {
        public void Login(string returnUrl = "/")
        {
            
        }

        [Authorize]
        public async Task Logout()
        {
          
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
