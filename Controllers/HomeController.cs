using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPass.Models;

namespace RandomPass.Controllers
{
    public class HomeController : Controller
    {
        public string str = "ABCDEFGHIJKLMNOQRSTUVWXZ0123456789";
        Random rand = new Random();
        public StringBuilder RandString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0; i< 14; i++)
            {
                sb.Append(str[rand.Next(0, str.Length)]);
            }
            return sb;
        }
        public IActionResult Index()
        {
            StringBuilder sb = new StringBuilder ();
            sb = RandString();
            ViewBag.sb = sb;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
