using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Shared.Domain.Repositories;

namespace CleanWave_Backend.Profiles.Domain.Repositories;

public interface ICleaningEntrepreneurRepository: IBaseRepository<CleaningEntrepreneur>
{
    Task<CleaningEntrepreneur> FindCleaningEntrepreneurByIdAsync(int id);
    Task<CleaningEntrepreneur> FindCleaningEntrepreneurByEmailAsync(string email);
}