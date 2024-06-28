using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Interfaces.REST.Resources;

namespace CleanWave_Backend.iam.Interfaces.REST.Transform;

public class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.Id, user.Username);
    }
}