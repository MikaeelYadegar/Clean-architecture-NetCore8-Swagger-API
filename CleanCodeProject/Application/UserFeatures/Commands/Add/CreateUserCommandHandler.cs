using Domain.Entities;
using Domain.Interfaces;
using Mapster;
using MediatR;
using System.Security.AccessControl;

namespace Application.UserFeatures.Commands.Add;

public class CreateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommandModel, Guid>
{
    public async Task<Guid> Handle(CreateUserCommandModel request, CancellationToken cancellationToken)
    {
        //var user = new User()
        //{
        //    FirstName = request.FirstName,
        //    LastName = request.LastName,
        //    Password = request.Password,
        //    UserName = request.UserName,

        //};
         var user=request.Adapt<User>();
         await userRepository.CreateUser(user);
        return user.Id;

    }
}
