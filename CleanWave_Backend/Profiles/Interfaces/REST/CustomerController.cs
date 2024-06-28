using System.Net.Mime;
using CleanWave_Backend.Profiles.Domain.Model.Queries;
using CleanWave_Backend.Profiles.Domain.Services;
using CleanWave_Backend.Profiles.Interfaces.REST.Resources;
using CleanWave_Backend.Profiles.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace CleanWave_Backend.Profiles.Interfaces.REST;
[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class CustomerController(ICustomerCommandService customerCommandService,
    ICustomerQueryService customerQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerResource createCustomerResource)
    {
        var createCustomerCommand =
            CreateCustomerCommandFromResourceAssembler.ToCommandFromResource(createCustomerResource);
        var customer = await customerCommandService.Handle(createCustomerCommand);
        if (customer is null) return BadRequest();
        var resource = CustomerResourceFromEntityAssembler.ToResourceFromEntity(customer);
        return CreatedAtAction(nameof(GetCustomerId), new { customerId = resource.Id }, resource);
    }
    [HttpGet("{customerId:int}")]
    public async Task<IActionResult> GetCustomerId([FromRoute] int customerId)
    {
        var getCustomerByIdQuery = new GetCustomerByIdQuery(customerId);
        var customer = await customerQueryService.Handle(getCustomerByIdQuery);
        if (customer is null) return BadRequest();
        var resource = CustomerResourceFromEntityAssembler.ToResourceFromEntity(customer);
        return Ok(resource);
    }
    [HttpGet("{email}")]
    public async Task<IActionResult> GetCustomerByEmail([FromRoute] string email)
    {
        var getCustomerByEmailQuery = new GetCustomerByEmailQuery(email);
        var customer = await customerQueryService.Handle(getCustomerByEmailQuery);
        if (customer is null) return BadRequest();
        var resource = CustomerResourceFromEntityAssembler.ToResourceFromEntity(customer);
        return Ok(resource);
    }
}