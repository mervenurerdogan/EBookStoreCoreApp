using EBookStoreBusiness.Abstract;
using EBookStoreBusiness.Concrete;
using EBookStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EBookStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _bookService;

        public HomeController(ICategoryService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
           var dgr= _bookService.GetAll();
            return View(dgr);
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