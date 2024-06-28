using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Queries;

namespace CleanWave_Backend.Profiles.Domain.Services;

public interface ICleaningEntrepreneurQueryService
{
    Task<CleaningEntrepreneur?> Handle(GetCleaningEntrepreneurByIdQuery query);
    Task<CleaningEntrepreneur?> Handle(GetCleaningEntrepreneurByEmailQuery query);
}