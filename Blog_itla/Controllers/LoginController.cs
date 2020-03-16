using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog_itla.modelUser;

namespace Blog_itla.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String User, String pass )
        {
            ModelUser user = new ModelUser();
            var validacion = user.Login(User, pass);
           
                if (validacion == true)
                {
                    return RedirectToAction("Index", "Blogs");
                }
                else
                {
                ViewBag.mess = "La contraseña o el usuario es incorrecta ";
                    return View();
                }

        }
      
    }
}