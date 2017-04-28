using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //using is imports for java users, or #include for C++ users, same concept.

namespace dontnetcore1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Utilization of .NET Core to throwback "views" as web pages with information on them.
        {
            return View();
        }

        public IActionResult About() //IActionResult type is used when you want to send a server response via a view
        {
            ViewData["Message"] = "Your application description page."; //Viewdata is the data sent to the view. So if you're looking
            // at a web page, you would see some part of it wih the contents of "Message" in this case.

            return View();
        }

        public IActionResult John()
        {
            ViewData["Message"] = "This is some message";
            ViewData["Someotherthing"] = "This is some other thing";
            return View();
        }

        public string Random(int min, int max, int[] exclude)  // Generates random numbers and doesn't generate numbers in exclude array
        {
            Random r = new Random();
            if (exclude.Length > (max - min)) return "nah";
            int number = r.Next(min, max);
            while(exclude.Contains(number))
            {
                number = r.Next(min, max);
            }
            return number.ToString();
        }

        public string Mau(string name)
        {
            return "<h1>Hi, "+name+"!</h1>";
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
