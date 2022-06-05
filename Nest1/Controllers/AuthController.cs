using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest1.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Registr()
        {
            return View();
        }
    }
}
