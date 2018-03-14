using System;
using System.Web.Mvc;

namespace FileBase_Authentication.Controllers
{
    public class FireBaseDatabaseController : Controller
    {
        // GET: FireBaseDatabase
        public ActionResult Index()
        {
            ViewBag.Id = Guid.NewGuid();
            return View();
        }
    }
}