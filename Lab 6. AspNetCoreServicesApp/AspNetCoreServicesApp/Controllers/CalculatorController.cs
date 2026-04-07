using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesApp.Controllers
{
    public class CalculatorController : Controller
    {
        private ICalculatorService _calculator;
        public CalculatorController( ICalculatorService calculator)
        {
            _calculator = calculator;
        }

        public override void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
        {
            ViewBag.OperationType = context.ActionDescriptor.RouteValues["action"];
            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTwoDecimals()
        {
            var random = new System.Random();
            decimal a = random.Next(1, 100);
            decimal b = random.Next(1, 100);

            decimal result = _calculator.Add(a, b);

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Result = result;
            return View("Result");
        }

        public IActionResult SubtractTwoDecimals()
        {
            var random = new System.Random();
            decimal a = random.Next(1, 100);
            decimal b = random.Next(1, 100);

            decimal result = _calculator.Subtract(a, b);

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Result = result;
            return View("Result");
        }

        public IActionResult MultiplyTwoDecimals()
        {
            var random = new System.Random();
            decimal a = random.Next(1, 100);
            decimal b = random.Next(1, 100);

            decimal result = _calculator.Multiply(a, b);

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Result = result;
            return View("Result");
        }

        public IActionResult DivideTwoDecimals()
        {
            var random = new System.Random();
            decimal a = random.Next(1, 100);
            decimal b = random.Next(1, 100);

            decimal result = _calculator.Divide(a, b);

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Result = result;
            return View("Result");
        }
    }
}
