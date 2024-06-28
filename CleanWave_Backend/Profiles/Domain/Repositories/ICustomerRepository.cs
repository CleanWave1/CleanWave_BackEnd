using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Shared.Domain.Repositories;

namespace CleanWave_Backend.Profiles.Domain.Repositories;

public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<Customer> FindCustomerByIdAsync(int customerId);
    Task<Customer> FindCustomerByEmailAsync(string email);
}