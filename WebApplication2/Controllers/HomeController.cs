using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bleh()
        {
            // Load an image from disk
            System.Drawing.Bitmap Image = (System.Drawing.Bitmap)System.Drawing.Image.FromFile("images/1934698.jpg");

            // Edit Image
            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    System.Drawing.Color thiscolor = Image.GetPixel(x, y);
                    int average = (thiscolor.R + thiscolor.B + thiscolor.G) / 3;
                    Image.SetPixel(x, y, System.Drawing.Color.FromArgb(average, average, average));
                }
            }

            // Prep image for sending to user
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Send image
            return File(ms.ToArray(), "image/jpeg");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
