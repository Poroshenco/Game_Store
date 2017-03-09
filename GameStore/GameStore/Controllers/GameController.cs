using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;
using System.Data.Entity;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        GameContext db = new GameContext();

        public ActionResult Index()
        {
            IEnumerable<Game> games = db.Games;

            ViewBag.Games = games;

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Game game = db.Games.Find(id);
            
            return View(game);
        }

        [HttpPost]
        public ActionResult Edit(Game game)
        {
            db.Entry(game).State = EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Game g = db.Games.Find(id);

            if (g != null)
            {
                db.Games.Remove(g);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}