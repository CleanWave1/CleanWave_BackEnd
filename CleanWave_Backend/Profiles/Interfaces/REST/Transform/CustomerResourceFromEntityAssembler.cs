using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Interfaces.REST.Resources;

namespace CleanWave_Backend.Profiles.Interfaces.REST.Transform;

public class CustomerResourceFromEntityAssembler
{
    public static CustomerResource ToResourceFromEntity(Customer entity)
    {
        return new CustomerResource(entity.Id, entity.Name, entity.LastName, entity.Email, entity.Phone, entity.Space);
    }
}