using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NASAv1.Web.Controllers
{
    public class SatelliteController : Controller
    {
        // GET: Satellite
        public ActionResult Index()
        {
            return View();
        }

        // GET: Satellite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Satellite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Satellite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Satellite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Satellite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Satellite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Satellite/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}