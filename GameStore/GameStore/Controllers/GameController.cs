using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;
using System.Data.Entity;
using System.Drawing;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        GameContext db = new GameContext();

        public ActionResult Index()
        {
            IEnumerable<Game> games = db.Games;

            ViewBag.Games = games;

            ViewBag.UserAccess = UserAccess.SetAccess();

            return View();
        }

        [HttpGet]
        public ActionResult Buy(string name)
        {
            ViewBag.BuyName = name;

            return View(new Purchase() { GameName = name });
        }

        [HttpPost]
        public ActionResult Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            db.Purchases.Add(purchase);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ChangeUser()
        {
            UserAccess.Admin = !UserAccess.Admin;

            ViewBag.UserAccess = UserAccess.SetAccess();

            return RedirectToAction("Index");
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
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(game);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(game);
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