using Microsoft.AspNetCore.Mvc;
using MathCalculatorMVC.Models;

namespace MathCalculatorMVC.Controllers
{
    public class CalculatorController : Controller
    {

        private static List<Calculation> History = new List<Calculation>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(History.OrderByDescending(c => c.Id).ToList());
        }

        [HttpPost]
        public IActionResult Calculate(double x, double y, string op)
        {
            double result = 0;

            switch (op)
            {
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "*": result = x * y; break;
                case "/": result = y != 0 ? x / y : double.NaN; break;
                default: break;
            }

            var calc = new Calculation
            {
                Id = History.Count + 1,
                X = x,
                Y = y,
                Operator = op,
                Result = result
            };

            History.Add(calc);

            return RedirectToAction("Index");
        }
    }
}
