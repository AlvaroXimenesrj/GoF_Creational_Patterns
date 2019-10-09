using CreationalPatterns.Models.Singleton;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns.Controllers
{
    public class SingletonController : Controller
    {
        public IActionResult Index()
        {
            WebsiteMetadata metadata = WebsiteMetadata.GetInstance();
            return View("Index", metadata);
        }
    }
}
