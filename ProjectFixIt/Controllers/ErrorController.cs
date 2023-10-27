using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFixIt.Models;

namespace ProjectFixIt.Controllers
{
    public class ErrorController : Controller
    {

        private static IList<Error> errors = new List<Error>
        {
            new Error(){Id = 1, Title = "Problem z kontrolerem", ErrorMessage = "opis zgłoszenia",WorkerFound = "Tomasz",RepairStatus = "W Trakcie", FoundDate = DateTime.Now},
        };
        // GET: ErrorController
        public ActionResult Index()
        {
            return View(errors);
        }

        // GET: ErrorController/Details/5
        public ActionResult Details(int id)
        {
            return View(errors.FirstOrDefault(x => x.Id == id));
        }

        // GET: ErrorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ErrorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Error error)
        {
            error.Id = errors.Count + 1;
            error.FoundDate = DateTime.Now;
            errors.Add(error);
            return RedirectToAction("Index");
        }

        // GET: ErrorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(errors.FirstOrDefault(x => x.Id == id));
        }

        // POST: ErrorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Error error)
        {
            Error error1 = errors.FirstOrDefault(x => x.Id == id);
            error1.Title = error.Title;
            error1.ErrorMessage = error.ErrorMessage;
            error1.WorkerFound = error.WorkerFound;
            error1.RepairStatus = error.RepairStatus;

            return RedirectToAction("Index");
        }

        // GET: ErrorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(errors.FirstOrDefault(x => x.Id == id));
        }

        // POST: ErrorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Error error1 = errors.FirstOrDefault(x => x.Id == id);
            errors.Remove(error1);
            return RedirectToAction("Index");
        }
    }
}
