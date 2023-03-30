using EBookStoreBusiness.Abstract;
using EBookStoreModel.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EBookStoreMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public  async Task <IActionResult> Index()
        {
            var dgr=await _categoryService.GetAll();
            return View(dgr.Data);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryAdd()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAdd(CategoryAddDto categoryAddDto)
        {
         
                await _categoryService.Add(categoryAddDto); 
                return RedirectToAction("Index");
           
           
        }
    }
}
