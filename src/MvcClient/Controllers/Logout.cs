using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClient.Controllers
{
    [Route("Logout")]
    public class Logout : Controller
    {
        public IActionResult Signout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
