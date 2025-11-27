using AiTech.WebUI.DTOs.CategoryDtos;
using AiTech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            
            var categories=await _categoryService.GetAllAsync();


            return View(categories);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            await _categoryService.CreateAsync(categoryDto);

            return RedirectToAction(nameof(Index));
        }



















    }
}
