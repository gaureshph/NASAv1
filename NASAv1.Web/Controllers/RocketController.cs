using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NASAv1.Web.Controllers
{
    public class RocketController : Controller
    {
        // GET: Rocket
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rocket/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rocket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rocket/Create
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

        // GET: Rocket/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rocket/Edit/5
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

        // GET: Rocket/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rocket/Delete/5
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