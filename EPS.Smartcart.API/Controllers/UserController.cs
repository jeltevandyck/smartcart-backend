using MediatR;

namespace EPS.Smartcart.API.Controllers;

public class UserController : AbstractController
{
    protected UserController(IMediator mediator) : base(mediator)
    {
    }
}