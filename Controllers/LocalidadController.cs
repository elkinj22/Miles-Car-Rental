
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Miles_Car_Rental.Controllers
{
    public class LocalidadController : Controller
    {
        // GET: LocalidadController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LocalidadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocalidadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocalidadController/Create
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

        // GET: LocalidadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocalidadController/Edit/5
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

        // GET: LocalidadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocalidadController/Delete/5
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
