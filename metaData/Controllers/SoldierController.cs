using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web;
using System.Net;
using metaData.Models;
using System.Data.Entity;
using System.Data;

namespace metaData.Controllers
{
    public class SoldierController : Controller
    {

        private SoldiersDB db = new SoldiersDB();


        // GET: Soldier
        public ActionResult Index()
        {
            return View(db.Soldiers.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soldier soldier = db.Soldiers.Find(id);
            if (soldier == null)
            {
                return HttpNotFound();
            }
            return View(soldier);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "soldierId, name, ETS")] Soldier soldier)
        {
            if (ModelState.IsValid)
            {
                db.Soldiers.Add(soldier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soldier);
        }

        public ActionResult Delete(int? id)
        {
            if ( id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soldier soldier = db.Soldiers.Find(id);
            if (soldier == null)
            {
                return HttpNotFound();
            }
            return View(soldier);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Soldier soldier = db.Soldiers.Find(id);
            db.Soldiers.Remove(soldier);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

            protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
            
}