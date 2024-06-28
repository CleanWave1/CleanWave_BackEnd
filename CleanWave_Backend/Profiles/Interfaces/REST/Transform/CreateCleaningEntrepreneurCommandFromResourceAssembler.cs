using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Interfaces.REST.Resources;

namespace CleanWave_Backend.Profiles.Interfaces.REST.Transform;

public class CreateCleaningEntrepreneurCommandFromResourceAssembler
{
    public static CreateCleaningEntrepreneurCommand ToCommandFromResource(CreateCleaningEntrepreneurResource resource)
    {
        return new CreateCleaningEntrepreneurCommand(resource.Name, resource.Email, resource.Username);
    }
}