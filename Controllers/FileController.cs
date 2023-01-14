using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_Example.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles("TextFiles").Select(file =>
            Path.GetFileNameWithoutExtension(file)).ToArray();
            return View(files);
        }

        public ActionResult Content(string id)
        {
            string[] content = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() +
                "/TextFiles/" + id + ".txt");
            return View(content);
        }
    }
}