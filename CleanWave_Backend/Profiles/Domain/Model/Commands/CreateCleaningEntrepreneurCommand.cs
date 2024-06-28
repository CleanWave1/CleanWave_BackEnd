namespace CleanWave_Backend.Profiles.Domain.Model.Commands;

public record CreateCleaningEntrepreneurCommand(
    string Name,
    string Email,
    string Username);
