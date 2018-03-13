using System.Web.Mvc;

namespace FileBase_Authentication.Controllers
{
    public class FireBaseAuthenticationController : Controller
    {
        // GET: FireBaseAuthentication
        public ActionResult Index()
        {
            return View();
        }

        //Firebase Email & Password Authentication
        public ActionResult EmailPassword()
        {
            return View();
        }

        //Anonymous Authentication
        public ActionResult Anonymous()
        {
            return View();
        }

        //Facebook Popup
        public ActionResult FacebookPopup()
        {
            return View();
        }
    }
}