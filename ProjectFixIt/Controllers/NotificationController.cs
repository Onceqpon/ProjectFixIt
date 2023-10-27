using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFixIt.Models;

namespace ProjectFixIt.Controllers
{
    public class NotificationController : Controller
    {

        private static IList<Notification> notifications = new List<Notification>
        {
            new Notification(){Id = 1, Title = "Problem z kontrolerem", Description = "opis zgłoszenia",WorkerName = "Tomasz", Piority = "Wysoka", NotificationDate = DateTime.Now},
        };
        // GET: NotificationController
        public ActionResult Index()
        {
            return View(notifications);
        }

        // GET: NotificationController/Details/5
        public ActionResult Details(int id)
        {
            return View(notifications.FirstOrDefault(x => x.Id == id));
        }

        // GET: NotificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotificationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Notification notification)
        {

            notification.Id = notifications.Count + 1;
            notification.NotificationDate = DateTime.Now;
            notifications.Add(notification);
            return RedirectToAction("Index");
        }

        // GET: NotificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(notifications.FirstOrDefault(x => x.Id == id));
        }

        // POST: NotificationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Notification notification)
        {
            Notification notification1 = notifications.FirstOrDefault(x => x.Id == id);
            notification1.Title = notification.Title;
            notification1.Description = notification.Description;
            notification1.WorkerName = notification.WorkerName;
            notification1.Piority = notification.Piority;

            return RedirectToAction("Index");
        }

        // GET: NotificationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(notifications.FirstOrDefault(x => x.Id == id));
        }

        // POST: NotificationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Notification notification1 = notifications.FirstOrDefault(x => x.Id == id);
            notifications.Remove(notification1);
            return RedirectToAction("Index");
        }
    }
}
