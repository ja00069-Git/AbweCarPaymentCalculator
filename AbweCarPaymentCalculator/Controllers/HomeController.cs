using AbweCarPaymentCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AbweCarPaymentCalculator.Controllers
{
    /// <summary>
    /// Jabesi Abwe
    /// 26/01/2024
    /// The controller for the Payment Calculator.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Get request.
        /// </summary>
        /// <returns>The request</returns>
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fv = 0;
            return View();
        }

        /// <summary>
        /// Post request from the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>The request</returns>
        [HttpPost]
        public IActionResult Index(PaymentCalcModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fv = model.CalculateMonthlyPayment()!;
            }
            else
            {
                ViewBag.Fv = 0;
            }
            return View(model);
        }

    }
}
