using Application.UserFeatures.Commands.Add;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandModel model,IMediator mediator)
        {
            var responce = await mediator.Send(model);
            return Ok(responce);
        }
        
    }
}
