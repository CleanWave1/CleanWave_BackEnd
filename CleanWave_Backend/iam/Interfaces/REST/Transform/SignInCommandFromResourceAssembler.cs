using CleanWave_Backend.iam.Domain.Model.Commands;
using CleanWave_Backend.iam.Interfaces.REST.Resources;

namespace CleanWave_Backend.iam.Interfaces.REST.Transform;

public class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}