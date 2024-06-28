using CleanWave_Backend.Shared.Domain.Repositories;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;

namespace CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context) => _context = context;

    public async Task CompleteAsync() => await _context.SaveChangesAsync();
}