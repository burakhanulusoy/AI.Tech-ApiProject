using AiTech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AiTech.WebUI.Validators.ProjectValidators
{
    public class CreateProjectValidator:AbstractValidator<CreateProjectDto>
    {

        public CreateProjectValidator()
        {

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz")
                                 .MinimumLength(5).WithMessage("başlık min 5");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Başlık boş bırakılamaz");


        }


    }
}
