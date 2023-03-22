using MediatR;

namespace EPS.Smartcart.API.Controllers;

public class ProductController : AbstractController
{
    protected ProductController(IMediator mediator) : base(mediator)
    {
    }
}