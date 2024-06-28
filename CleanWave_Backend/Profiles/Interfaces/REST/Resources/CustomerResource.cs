using CleanWave_Backend.Profiles.Domain.Model.ValueObjects;

namespace CleanWave_Backend.Profiles.Interfaces.REST.Resources;

public record CustomerResource(
    int Id,
    string Name,
    string LastName,
    string Email,
    string Phone,
    SpaceDetails Space);