using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Interfaces.REST.Resources;

namespace CleanWave_Backend.Profiles.Interfaces.REST.Transform;

public class CreateCustomerCommandFromResourceAssembler
{
    public static CreateCustomerCommand ToCommandFromResource(CreateCustomerResource resource)
    {
        return new CreateCustomerCommand(resource.Name, resource.LastName, resource.Email, resource.Phone,
            resource.PropertyType, resource.CleaningType, resource.SpaceSize, resource.NumberRooms, resource.FloorType,
            resource.Instructions);
    }
}