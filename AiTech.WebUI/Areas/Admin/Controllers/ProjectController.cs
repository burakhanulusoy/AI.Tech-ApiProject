using AiTech.WebUI.DTOs.ProjectDtos;
using AiTech.WebUI.Services.CategoryServices;
using AiTech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController(IProjectService _projectService,ICategoryService _categoryService) : Controller
    {
        private async Task GetCategories()
        {
            var categories=await _categoryService.GetAllAsync();

            ViewBag.categories = (from category in categories
                                select new SelectListItem
                                {
                                    Text = category.Name,
                                    Value = category.Id.ToString()

                                }).ToList();




        }


        public async Task<IActionResult> Index()
        {

            var projects=await _projectService.GetAllAsync();
            return View(projects);
        }

        public async Task<IActionResult> CreateProject()
        {
            await GetCategories();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto createProjectDto)
        {

            if(!ModelState.IsValid)
            {
                await GetCategories();
                return View(createProjectDto);
            }

            await _projectService.CreateAsync(createProjectDto);

            return RedirectToAction("Index");

            
        }


        public async Task<IActionResult> UpdateProject(int id)
        {

            var project=await _projectService.GetByIdAsync(id);
            await GetCategories();
            return View(project);

        }

        [HttpPost]
        public async Task<IActionResult> UpdateProject(UpdateProjectDto updateProjectDto)
        {
            

            await _projectService.UpdateAsync(updateProjectDto);
            return RedirectToAction("Index");
            

        }

        public async Task<IActionResult> DeleteProject(int id)
        {

            await _projectService.DeleteAsync(id);
            return RedirectToAction("Index");
        }












    }
}
