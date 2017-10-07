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

        // Called when loading the page
        // GET: Tools
        public ActionResult RadioQualifier()
        {
            IEnumerable<EquipmentModel> equip = from e in db.EquipmentModels
                                                where e.Bandwidth < 0
                                                select e;

            return View(equip);
        }

        // Called when submitting form data
        // GET: Tools
        [HttpPost]
        public ActionResult RadioQualifier(double distance, int bandwidth, string sort, string lastSort, string lastSortOrder)
        {
            //Keeps previously entered data in the form fields.
            ViewBag.distance = distance;
            ViewBag.bandwidth = bandwidth;

            //Performs search
            IEnumerable<EquipmentModel> equip = from e in db.EquipmentModels
                                                where e.Distance >= distance
                                                where e.Bandwidth >= bandwidth
                                                select e;

            //Implements sort order parameter
            switch (sort)
            {
                case "make":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.Make);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.Make);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "make";
                    break;
                case "model":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.Model);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.Model);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "model";
                    break;
                case "distance":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.Distance);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.Distance);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "distance";
                    break;
                case "bandwidth":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.Bandwidth);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.Bandwidth);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "bandwidth";
                    break;
                case "license":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.License);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.License);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "license";
                    break;
                case "cost":
                    if (lastSortOrder == "Desc")
                    {
                        equip = equip.OrderBy(e => e.Cost);
                        ViewBag.lastSortOrder = "Asc";
                    }
                    else
                    {
                        equip = equip.OrderByDescending(e => e.Cost);
                        ViewBag.lastSortOrder = "Desc";
                    }
                    ViewBag.lastSort = "cost";
                    break;
                default:
                    equip = equip.OrderBy(e => e.Bandwidth);
                    ViewBag.lastSort = "bandwidth";
                    ViewBag.lastSortOrder = "Asc";
                    break;
            }


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
