using cloud_computing_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cloud_computing_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
