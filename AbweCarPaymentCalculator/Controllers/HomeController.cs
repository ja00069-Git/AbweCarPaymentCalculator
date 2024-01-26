using AbweCarPaymentCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AbweCarPaymentCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
