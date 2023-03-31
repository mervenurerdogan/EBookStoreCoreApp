using EBookStoreBusiness.Abstract;
using EBookStoreBusiness.Concrete;
using EBookStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            return View();
        }

    }
}