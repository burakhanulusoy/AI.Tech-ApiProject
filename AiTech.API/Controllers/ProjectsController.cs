using AiTech.Business.Services.ProjectServices;
using AiTech.DTO.ProjectDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController(IProjectService _projectService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var project=await _projectService.TGetAllAsync();
            return Ok(project);
        }


        [HttpGet("withCategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var prjects=await _projectService.TGetProjectsWithCatgeoriesAsync();
            return Ok(prjects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var projects=await _projectService.TGetByIdAsync(id);
            if(projects is null)
            {
                return BadRequest("Proje Bulunamadı");
            }

            return Ok(projects);


        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto createProjectDto)
        {
            await _projectService.TCreateAsync(createProjectDto);
            return Created();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProject(UpdateProjectDto updateProjectDto)
        {
            await _projectService.TUpdateAsync(updateProjectDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {

            await _projectService.TDeleteAsync(id);
            return NoContent();


        }


    }
}
