using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WikiVerde.Models;

namespace WikiVerde.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            if (TempData["retornoAutenticar"] != null)
            {
                ModelState.AddModelError(string.Empty, TempData["retornoAutenticar"].ToString());
            }
            return View();
        }
        [HttpPost]
        public IActionResult Autenticar(Login login)
        {
                MongoDbContext dbContext = new MongoDbContext();
                var usuario = dbContext.Logins.Find(m => m.Email == login.Email && m.Senha == login.Senha).FirstOrDefault();
                

                if (usuario != null)
                {
                    usuario.DataAcesso = DateTime.Now;
                    dbContext.Logins.ReplaceOne(m => m.Email == login.Email && m.Senha == login.Senha, usuario);
                    HttpContext.Session.SetString("SessionName", usuario.Name);

                return RedirectToAction("Home", "Home");
                }
                else{
                    TempData["retornoAutenticar"] = "Email e ou Senha inválidos";
                    return RedirectToAction("Login");
                }
          
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Login login)
        {
            if (ModelState.IsValid)
            {
                MongoDbContext dbContext = new MongoDbContext();
                login.Id = Guid.NewGuid();
                login.CreateDate = DateTime.Now;
                dbContext.Logins.InsertOne(login);
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View(login);
            }
        }
    }
}
