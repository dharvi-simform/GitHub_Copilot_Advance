using GitHub_Copilot_Advance.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitHub_Copilot_Advance.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            // TODO: Add input validation
            // Currently there is no validation — any input is accepted
            if (ModelState.IsValid)
            {
                // Simulate successful registration
                TempData["Message"] = $"User '{model.Username}' registered successfully!";
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
