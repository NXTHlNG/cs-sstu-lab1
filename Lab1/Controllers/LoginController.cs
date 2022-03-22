using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using System.Collections.Generic;

namespace Lab1.Controllers
{
    public class LoginController : Controller
    {
        private static IDictionary<string, string> dictionary = new Dictionary<string, string>();

        static LoginController()
        {
            dictionary.Add("admin", "admin");
            dictionary.Add("root", "root");
            dictionary.Add("qwerty", "123456");
            dictionary.Add("123456", "qwerty");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn(LoginViewModel model)
        {
            if (model.Login == null || model.Password == null)
            {
                return View("InvalidSignIn");
            }

            string confrimPass;

            try
            {
                confrimPass = dictionary[model.Login];
            }
            catch (KeyNotFoundException e)
            {
                return View("InvalidSignIn");
            }

            if (confrimPass != null && confrimPass == model.Password)
            {
                return View(model);
            }

            return View("InvalidSignIn");
        }
    }
}
