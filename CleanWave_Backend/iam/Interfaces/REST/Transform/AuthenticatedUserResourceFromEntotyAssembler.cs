using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Interfaces.REST.Resources;

namespace CleanWave_Backend.iam.Interfaces.REST.Transform;

public class AuthenticatedUserResourceFromEntotyAssembler
{
    public static AuthenticatedUserResource ToResourceFromEntity(User user, string token)
    {
        return new AuthenticatedUserResource(user.Id, user.Username, token);
    }
}