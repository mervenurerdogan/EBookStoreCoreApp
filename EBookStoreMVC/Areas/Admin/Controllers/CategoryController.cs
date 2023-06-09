﻿using EBookStoreBusiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService= categoryService;
        }
        public async Task< IActionResult> Index()
        {
            var result = await _categoryService.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        
    }
}
