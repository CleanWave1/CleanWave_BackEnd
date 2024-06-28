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
public class CleaningEntrepreneurController(ICleaningEntrepreneurCommandService entrepreneurCommandService,
    ICleaningEntrepreneurQueryService entrepreneurQueryService): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateEntrepreneur([FromBody] CreateCleaningEntrepreneurResource createCleaningEntrepreneurResource)
    {
        var createEntrepreneurCommand =
            CreateCleaningEntrepreneurCommandFromResourceAssembler.ToCommandFromResource(createCleaningEntrepreneurResource);
        var entrepreneur = await entrepreneurCommandService.Handle(createEntrepreneurCommand);
        if (entrepreneur is null) return BadRequest();
        var resource = CleaningEntrepreneurResourceFromEntityAssembler.ToResourceFromEntity(entrepreneur);
        return CreatedAtAction(nameof(GetEntrepreneurById), new { id = resource.Id }, resource);
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEntrepreneurById([FromRoute] int id)
    {
        var getEntrepreneurByIdQuery = new GetCleaningEntrepreneurByIdQuery(id);
        var entrepreneur = await entrepreneurQueryService.Handle(getEntrepreneurByIdQuery);
        if (entrepreneur is null) return BadRequest();
        var resource = CleaningEntrepreneurResourceFromEntityAssembler.ToResourceFromEntity(entrepreneur);
        return Ok(resource);
    }
    [HttpGet("{email}")]
    public async Task<IActionResult> GetEntrepreneurByEmail([FromRoute] string email)
    {
        var getEntrepreneurByEmailQuery = new GetCleaningEntrepreneurByEmailQuery(email);
        var entrepreneur = await entrepreneurQueryService.Handle(getEntrepreneurByEmailQuery);
        if (entrepreneur is null) return BadRequest();
        var resource = CleaningEntrepreneurResourceFromEntityAssembler.ToResourceFromEntity(entrepreneur);
        return Ok(resource);
    }
}