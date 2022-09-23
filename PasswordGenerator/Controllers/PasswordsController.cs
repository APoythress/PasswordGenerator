using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using PasswordGeneratorClasses;
using PasswordGeneratorClasses.Models;
using System.Security.Cryptography.X509Certificates;

namespace PasswordGenerator.Controllers
{
    public class PasswordsController : Controller
    {
        public ActionResult Index()
        {
            PasswordsViewModel model = new();
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(int numOfChars, bool useSpecial)
        {
            PasswordsViewModel model = new();
            PasswordController.GetPassword();
            return View(model);
        }

        public IActionResult Update()
        {
            PasswordsViewModel model = new PasswordsViewModel();
            return View(model);
        }
    }
}
