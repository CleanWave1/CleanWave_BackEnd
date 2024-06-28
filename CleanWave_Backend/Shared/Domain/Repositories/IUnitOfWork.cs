namespace CleanWave_Backend.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}