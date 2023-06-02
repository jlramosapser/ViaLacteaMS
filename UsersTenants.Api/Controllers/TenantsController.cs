using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UsersTenants.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TenantsController : ControllerBase
  {

    private readonly ILogger<TenantsController> _logger;
    private readonly IMediator _mediator;

    public TenantsController(ILogger<TenantsController> logger, IMediator mediator)
    {
      _logger = logger;
      _mediator = mediator;
    }

    //[HttpGet]
    //public async Task<ActionResult> GetTenants()
    //{
    //  var tenants = await _mediator.Send(new GetTenantsQuery());

    //  return Ok(tenants);
    //}

    //[HttpGet("{id:int}", Name = "GetTenantById")]
    //public async Task<ActionResult> GetTenantById(int id)
    //{
    //  var tenant = await _mediator.Send(new GetTenantByIdQuery(id));

    //  return Ok(tenant);
    //}

    //[HttpPost]
    //public async Task<ActionResult> AddTenant([FromBody] Tenant tenant)
    //{
    //  var tenantToReturn = await _mediator.Send(new AddTenantCommand(tenant));

    //  await _mediator.Publish(new TenantAddedNotification(tenantToReturn));

    //  return CreatedAtRoute("GetTenantById", new { id = tenantToReturn.Id }, tenantToReturn);
    //}

  }
}