using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UsersTenants.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {

    private readonly ILogger<UsersController> _logger;
    private readonly IMediator _mediator;

    public UsersController(ILogger<UsersController> logger, IMediator mediator)
    {
      _logger = logger;
      _mediator = mediator;
    }

  }
}