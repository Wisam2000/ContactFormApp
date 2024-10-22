using Microsoft.AspNetCore.Mvc;
using ContactFormApp.Models;

namespace ContactFormApp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // You can add code here to save the data or send an email, etc.
                ViewBag.Message = "Your contact information has been submitted successfully!";
                return View(contact);
            }
            return View();
        }
    }
}
