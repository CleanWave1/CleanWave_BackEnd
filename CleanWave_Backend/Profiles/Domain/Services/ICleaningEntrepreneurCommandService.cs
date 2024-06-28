using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Commands;

namespace CleanWave_Backend.Profiles.Domain.Services;

public interface ICleaningEntrepreneurCommandService
{
    Task<CleaningEntrepreneur> Handle(CreateCleaningEntrepreneurCommand command);
}