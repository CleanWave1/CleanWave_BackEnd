using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanWave_Backend.Profiles.Infraestructure.Persistence.EFC.Repositories;

public class CleaningEntrepreneurRepository(AppDbContext context):BaseRepository<CleaningEntrepreneur>(context), ICleaningEntrepreneurRepository
{
    public Task<CleaningEntrepreneur?> FindCleaningEntrepreneurByIdAsync(int id)
    {
        return Context.Set<CleaningEntrepreneur>().Where(c => c.Id == id)
            .FirstOrDefaultAsync();
    }

    public Task<CleaningEntrepreneur?> FindCleaningEntrepreneurByEmailAsync(string email)
    {
        return Context.Set<CleaningEntrepreneur>().Where(c => c.Email == email)
            .FirstOrDefaultAsync();
    }
}