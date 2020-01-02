using SuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeros.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext db;
        public SuperheroesController()
        {
            db = new ApplicationDbContext();
        }
        //SuperHero superHero = new SuperHero();
        // GET: Superheroes
        public ActionResult Index()
        {
            var superHeroes = db.SuperHeroes.ToList();
            return View(superHeroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            var hero = db.SuperHeroes.Where(h => h.Id == id).FirstOrDefault();
            return View(hero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.SuperHeroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var hero = db.SuperHeroes.Where(h => h.Id == id).FirstOrDefault();
            return View(hero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero hero)
        {
            var newhero = db.SuperHeroes.Where(h => h.Id == id).FirstOrDefault();
            try
            {
                // TODO: Add update logic here
                db.SuperHeroes.Remove(newhero);
                db.SaveChanges();
                newhero.Name = hero.Name;
                newhero.alterEgo = hero.alterEgo;
                newhero.primarySuperheroAbility = hero.primarySuperheroAbility;
                newhero.secondarySuperheroAbility = hero.secondarySuperheroAbility;
                newhero.catchpharse = hero.catchpharse;
                db.SuperHeroes.Add(newhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            var hero = db.SuperHeroes.Where(h => h.Id == id).FirstOrDefault();

            return View(hero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            superHero = db.SuperHeroes.Where(h => h.Id == id).FirstOrDefault();
            try
            {
                // TODO: Add delete logic here
                
                db.SuperHeroes.Remove(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(superHero);
            }
        }
    }
}
