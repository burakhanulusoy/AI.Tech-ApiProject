using AiTech.DTO.CategoryDtos;

namespace AiTech.DTO.ProjectDtos
{
    public record  ResultProjectDto(
        int Id,
        string Title,
        string ImageUrl,
        int CategoryId,
        ResultCategoryDto Category

        
        
        );
    
}
