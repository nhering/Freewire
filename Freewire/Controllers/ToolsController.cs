using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Freewire.Models;

namespace Freewire.Controllers
{
    public class ToolsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tools
        public ActionResult RadioQualifier()
        {
            return View();
        }

        // GET: Tools
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadioQualifier(int distance, int bandwidth)
        {
            return View(db.EquipmentModels.ToList());
        }

        // GET: Tools/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tools/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tools/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tools/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tools/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tools/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
