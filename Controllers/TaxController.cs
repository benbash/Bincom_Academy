using Microsoft.AspNetCore.Mvc;
using BashCVPortfolio.Models;
using BashCVPortfolio.Services;

namespace BashCVPortfolio.Controllers
{
    public class TaxController : Controller
    {
        private readonly NigeriaTaxService _taxService;

        public TaxController(NigeriaTaxService taxService)
        {
            _taxService = taxService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TaxCalculatorViewModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TaxCalculatorViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _taxService.CalculateTax(model);

            return View(model);
        }

    }
}