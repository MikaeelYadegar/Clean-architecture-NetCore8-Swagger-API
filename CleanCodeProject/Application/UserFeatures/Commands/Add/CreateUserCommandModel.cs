using FluentValidation;
using MediatR;

namespace Application.UserFeatures.Commands.Add;

public record CreateUserCommandModel(string FirstName,string LastName,string UserName,string NationalCode,string Password)
    :IRequest<Guid>;

