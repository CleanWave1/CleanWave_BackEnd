using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanWave_Backend.Profiles.Infraestructure.Persistence.EFC.Repositories;

public class CustomerRepository(AppDbContext context):BaseRepository<Customer>(context), ICustomerRepository
{
    public Task<Customer?> FindCustomerByIdAsync(int customerId)
    {
        return Context.Set<Customer>().Where(c => c.Id == customerId)
            .FirstOrDefaultAsync();
    }

    public Task<Customer?> FindCustomerByEmailAsync(string email)
    {
        return Context.Set<Customer>().Where(c => c.Email == email)
            .FirstOrDefaultAsync();
    }
}