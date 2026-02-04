namespace MaaldoCom.Services.Application.Dtos.Validators;

public class CreateMediaValidator : AbstractValidator<MediaDto>
{
    public CreateMediaValidator()
    {
        RuleFor(x => x.FileName)
            .NotEmpty()
            .WithMessage("FileName is required")
            .MaximumLength(50)
            .WithMessage("FileName must be 50 characters or less");
        RuleFor(x => x.FileExtension)
            .NotEmpty()
            .WithMessage("FileExtension is required")
            .MaximumLength(20)
            .WithMessage("FileExtension must be 20 characters or less");
    }
}
