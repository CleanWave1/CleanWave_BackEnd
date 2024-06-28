namespace CleanWave_Backend.Profiles.Domain.Model.Commands;

public record CreateCustomerCommand(
    string Name,
    string LastName,
    string Email,
    string Phone,
    string PropertyType,
    string CleaningType,
    string SpaceSize,
    int? NumberRooms,
    string FloorType,
    string Instructions);
