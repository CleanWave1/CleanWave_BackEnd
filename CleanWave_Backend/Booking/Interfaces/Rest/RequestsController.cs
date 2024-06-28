using CleanWave_Backend.Booking.Domain.Model.Queries;
using CleanWave_Backend.Booking.Domain.Services;
using CleanWave_Backend.Booking.Interfaces.Rest.Resources;
using CleanWave_Backend.Booking.Interfaces.Rest.Transform;
using Microsoft.AspNetCore.Mvc;

namespace CleanWave_Backend.Booking.Interfaces.Rest;

[ApiController]
[Route("api/v1/[controller]")]
public class RequestsController(IRequestCommandServices requestCommandServices, IRequestQueryServices requestQueryServices): ControllerBase
{
    
    [HttpPost]
    public async Task<IActionResult> CreateRequest([FromBody] CreateRequestResource createRequestResource)
    {
        var createRequestCommand =
            CreateRequestCommandFromResourceAssembler.ToCommandFromResource(createRequestResource);
        var request = await requestCommandServices.Handle(createRequestCommand);
        if (request is null) return BadRequest();
        var resource = RequestResourceFromEntityAssembler.ToResourceFromEntity(request);
        return CreatedAtAction(nameof(GetRequestById), new { requestId = resource.Id }, resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllRequests()
    {
        var getAllRequestsQuery = new GetAllRequestsQuery();
        var requests = await requestQueryServices.Handle(getAllRequestsQuery);
        var resources = requests.Select(RequestResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpGet("{requestId:int}")]
    public async Task<IActionResult> GetRequestById([FromRoute] int requestId)
    {
        var request = await requestQueryServices.Handle(new GetRequestByIdQuery(requestId));
        if (request is null) return BadRequest();
        var resource = RequestResourceFromEntityAssembler.ToResourceFromEntity(request);
        return Ok(resource);
    }
}