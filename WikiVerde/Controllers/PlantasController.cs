using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WikiVerde.Models;

namespace WikiVerde.Controllers
{
    public class PlantasController : Controller
    {
        public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Planta> listaPlantas = dbContext.Plantas.Find(m => true).ToList();
            return View(listaPlantas);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            var entity = dbContext.Plantas.Find(m => m.Id == id).FirstOrDefault();
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Planta entity)
        {
            if (ModelState.IsValid)
            {
                MongoDbContext dbContext = new MongoDbContext();
                dbContext.Plantas.ReplaceOne(m => m.Id == entity.Id, entity);
                return RedirectToAction("Index", "Plantas");
            }
            else
            {
                return View(entity);
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Planta entity)
        {
            if (ModelState.IsValid)
            {
                MongoDbContext dbContext = new MongoDbContext();
                entity.Id = Guid.NewGuid();
                dbContext.Plantas.InsertOne(entity);
                return RedirectToAction("Index", "Plantas");
            }
            else
            {
                return View(entity);
            }
            
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Plantas.DeleteOne(m => m.Id == id);
            return RedirectToAction("Index", "Plantas");
        }
    }
}

