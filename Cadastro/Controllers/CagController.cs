using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class CagController : Controller
    {
        // GET: CagController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CagController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CagController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CagController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CagController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CagController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
