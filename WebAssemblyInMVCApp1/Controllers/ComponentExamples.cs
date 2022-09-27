using Microsoft.AspNetCore.Mvc;
using WebAssemblyInMVCApp1.Models;

namespace WebAssemblyInMVCApp1.Controllers
{
    public class ComponentExamples : Controller
    {
        private Item item1 = new Item()
        {
            Id = 1,
            Name = "Name",
            Description = "Description",
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Server()
        {
            return View(item1);
        }

        public IActionResult ServerPrerendered()
        {
            return View(item1);
        }

        public IActionResult Static()
        {
            return View(item1);
        }

        public IActionResult WebAssembly()
        {
            return View(item1);
        }

        public IActionResult WebAssemblyPrerendered()
        {
            return View(item1);

        }
    }
}
