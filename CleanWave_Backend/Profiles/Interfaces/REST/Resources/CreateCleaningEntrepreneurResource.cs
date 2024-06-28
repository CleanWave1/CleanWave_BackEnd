namespace CleanWave_Backend.Profiles.Interfaces.REST.Resources;

public record CreateCleaningEntrepreneurResource(
    string Name,
    string Email,
    string Username
);