using AiTech.WebUI.DTOs.CategoryDtos;

namespace AiTech.WebUI.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllAsync();
        Task<UpdateCategoryDto> GetByIdAsync(int id);
        Task CreateAsync(CreateCategoryDto categoryDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateCategoryDto categoryDto);



    }
}
