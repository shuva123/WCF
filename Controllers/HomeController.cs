using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(double firstNumber, double secondNumber, string Cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;
            CalculatorServiceReference.CalulatorClient calculatorClient = new CalculatorServiceReference.CalulatorClient();
            switch (Cal)
            {
                case "Add":
                    c = Convert.ToInt32(calculatorClient.AddNumber(firstNumber, secondNumber));
                    break;
                case "Sub":
                    c = Convert.ToInt32(calculatorClient.SubNumber(firstNumber, secondNumber));
                    break;
            }
            ViewBag.Result = c;
            ViewBag.FirstNumber = a;
            ViewBag.SecondNumber = b;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}