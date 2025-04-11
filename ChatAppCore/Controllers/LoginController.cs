using Microsoft.AspNetCore.Mvc;

namespace ChatAppCore.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Views/Login/Index.cshtml
        }

        [HttpPost]
        public IActionResult Index(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                HttpContext.Session.SetString("UserName", username);
                return RedirectToAction("Chat", "Chat");
            }

            ViewBag.Error = "Please enter a username.";
            return View();
        }
    }
}
