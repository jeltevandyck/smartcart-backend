using MediatR;

namespace EPS.Smartcart.API.Controllers;

public class StoreController : AbstractController
{
    protected StoreController(IMediator mediator) : base(mediator)
    {
    }
}