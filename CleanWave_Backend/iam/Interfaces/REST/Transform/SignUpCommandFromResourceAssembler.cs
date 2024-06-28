using CleanWave_Backend.iam.Domain.Model.Commands;
using CleanWave_Backend.iam.Interfaces.REST.Resources;

namespace CleanWave_Backend.iam.Interfaces.REST.Transform;

public class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}