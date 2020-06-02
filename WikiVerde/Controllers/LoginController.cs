using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WikiVerde.Models;

namespace WikiVerde.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Autenticar(Login login)
        {
            return RedirectToAction("Home", "Home");
        }

    }
}
