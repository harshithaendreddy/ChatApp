using Microsoft.AspNetCore.Mvc;
using ChatAppCore.Models;

namespace ChatAppCore.Controllers
{
    public class ChatController : Controller
    {
        private readonly ChatMessageStore _chatStore;

        public ChatController(ChatMessageStore chatStore)
        {
            _chatStore = chatStore;
        }

        public IActionResult Chat()
        {
            var username = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Index", "Login");

            ViewBag.UserName = username;
            return View(); // looks for Views/Chat/Chat.cshtml
        }

        [HttpPost]
        public IActionResult SendMessage(string message)
        {
            var username = HttpContext.Session.GetString("UserName");
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(message))
            {
                _chatStore.AddMessage($"{username}: {message}");
            }

            return RedirectToAction("Display");
        }

        public IActionResult Display()
        {
            var messages = _chatStore.GetMessages();
            return View(messages); // expects Views/Chat/Display.cshtml
        }
    }
}
