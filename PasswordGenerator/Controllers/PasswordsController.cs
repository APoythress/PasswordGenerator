using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.DataAccess.Controller;
using PasswordGenerator.DataAccess.Models;
using PasswordGenerator.Models;
using System.Security.Cryptography.X509Certificates;

namespace PasswordGenerator.Controllers
{
    public class PasswordsController : Controller
    {
       

        public ActionResult Index()
        {
            PasswordsViewModel model = new PasswordsViewModel();
  
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(PasswordsViewModel model)
        {
           PasswordController passwords = new PasswordController();
            var passwordModel = new PasswordModel()
            {
                NumOfChars = model.NumOfChars,
                UseSpecialChars = model.UseSpecialChars,
                PasswordGenerated = model.PasswordGenerated,

            };
            
            model.PasswordGenerated = passwords.CreatePassword(passwordModel);
            return View(model);
        }

        public IActionResult Update()
        {
            PasswordsViewModel model = new PasswordsViewModel();
            return View(model);
        }
    }
}
