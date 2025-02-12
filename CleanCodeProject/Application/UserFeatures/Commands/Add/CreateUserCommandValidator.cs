using FluentValidation;

namespace Application.UserFeatures.Commands.Add;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommandModel>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(100)
            .WithErrorCode("500")
            .WithMessage("مقدار نام نباید خالی یا بیشتر از 100 کاراکتر باشد");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(100)
            .WithErrorCode("500")
            .WithMessage("مقدار نام خانوادگی نباید خالی یا بیشتر از 100 کاراکتر باشد");
    }
}
