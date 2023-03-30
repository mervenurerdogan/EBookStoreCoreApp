using EBookStoreBusiness.Abstract;
using EBookStoreBusiness.Concrete;
using EBookStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _bookService;

        public HomeController(ICategoryService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
           var dgr= await _bookService.GetAllByNonDeleted();
            if (dgr.ResultStatus == ResultStatus.Success)
            {
                return View(dgr.Data);
            }
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