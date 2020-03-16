using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_itla.modelUser;
using Microsoft.AspNetCore.Mvc;

namespace Blog_itla.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String Nom, String User, String pass, int edad, String direcion)
        {
            ModelUser user = new ModelUser();
            var validacion = user.Registro(Nom, User , pass , edad , direcion);
            if (validacion == true)
            {
                return View();
            }
            else
            {
                return View();
            }
           
        }
    }
}