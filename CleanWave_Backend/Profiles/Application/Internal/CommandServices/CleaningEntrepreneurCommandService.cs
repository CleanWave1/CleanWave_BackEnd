using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Profiles.Domain.Services;
using CleanWave_Backend.Shared.Domain.Repositories;

namespace CleanWave_Backend.Profiles.Application.Internal.CommandServices;

public class CleaningEntrepreneurCommandService(ICleaningEntrepreneurRepository repository, IUnitOfWork unitOfWork) : ICleaningEntrepreneurCommandService
{
    public async Task<CleaningEntrepreneur> Handle(CreateCleaningEntrepreneurCommand command)
    {
        var entrepreneur = new CleaningEntrepreneur(command);
        try
        {
            await repository.AddSync(entrepreneur);
            await unitOfWork.CompleteAsync();
            return entrepreneur;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured while creating the entrepreneur:  {e.Message}");
            return null;
        }
    }
}