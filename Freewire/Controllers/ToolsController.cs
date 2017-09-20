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

        //Called when loading the page from the tools menu
        // GET: Tools
        public ActionResult RadioQualifier()
        {
            IEnumerable<EquipmentModel> equip = from e in db.EquipmentModels
                                                where e.Bandwidth == 0
                                                select e;

            return View(equip);
        }

        //Called when submitting form data
        // GET: Tools
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadioQualifier(int distance, int bandwidth)
        {
            //Keeps previously entered data in the form fields.
            ViewBag.distance = distance;
            ViewBag.bandwidth = bandwidth;

            IEnumerable<EquipmentModel> equip = from e in db.EquipmentModels
                                                where e.Distance >= distance
                                                where e.Bandwidth >= bandwidth
                                                select e;

            return View(equip);
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
