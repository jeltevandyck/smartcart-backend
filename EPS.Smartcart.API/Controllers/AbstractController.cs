using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class AbstractController : Controller
{
    protected readonly IMediator _mediator;
    
    protected AbstractController(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected string GetAuth0Id()
    {
        var auth0Id = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        if (auth0Id == null)
        {
            return "Auth0|000000000000000000000000";
        }
        
        return auth0Id;
    }
}