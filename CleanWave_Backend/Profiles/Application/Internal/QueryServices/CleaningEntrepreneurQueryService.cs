using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Queries;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Profiles.Domain.Services;

namespace CleanWave_Backend.Profiles.Application.Internal.QueryServices;

public class CleaningEntrepreneurQueryService(ICleaningEntrepreneurRepository repository) : ICleaningEntrepreneurQueryService
{
    public async Task<CleaningEntrepreneur?> Handle(GetCleaningEntrepreneurByIdQuery query)
    {
        return await repository.FindCleaningEntrepreneurByIdAsync(query.Id);
    }

    public async Task<CleaningEntrepreneur?> Handle(GetCleaningEntrepreneurByEmailQuery query)
    {
        return await repository.FindCleaningEntrepreneurByEmailAsync(query.Email);
    }
}