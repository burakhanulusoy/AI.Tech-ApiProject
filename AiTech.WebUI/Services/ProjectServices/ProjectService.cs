using AiTech.WebUI.DTOs.ProjectDtos;

namespace AiTech.WebUI.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7235/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateProjectDto createProject)
        {
            await _client.PostAsJsonAsync("projects", createProject);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("projects/"+id);
        }

        public async Task<List<ResultProjectDto>> GetAllAsync()
        {

            var projects = await _client.GetFromJsonAsync<List<ResultProjectDto>>("projects/withCategories");
            return projects;




        }

        public async Task<UpdateProjectDto> GetByIdAsync(int id)
        {
            var projects=await _client.GetFromJsonAsync<UpdateProjectDto>("projects/"+id);
            return projects;


        }

        public async Task UpdateAsync(UpdateProjectDto updateProject)
        {

            await _client.PutAsJsonAsync("projects", updateProject);

        }
    }
}
