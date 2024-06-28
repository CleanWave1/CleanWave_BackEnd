using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Interfaces.REST.Resources;

namespace CleanWave_Backend.Profiles.Interfaces.REST.Transform;

public class CleaningEntrepreneurResourceFromEntityAssembler
{
    public static CleaningEntrepreneurResource ToResourceFromEntity(CleaningEntrepreneur entity)
    {
        return new CleaningEntrepreneurResource(entity.Id, entity.Name, entity.Email, entity.Username);
    }
}