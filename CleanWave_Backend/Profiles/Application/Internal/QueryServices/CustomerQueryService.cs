using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Queries;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Profiles.Domain.Services;

namespace CleanWave_Backend.Profiles.Application.Internal.QueryServices;

public class CustomerQueryService(ICustomerRepository repository): ICustomerQueryService
{
    public async Task<Customer?> Handle(GetCustomerByIdQuery query)
    {
        return await repository.FindCustomerByIdAsync(query.CustomerId);
    }

    public async Task<Customer?> Handle(GetCustomerByEmailQuery query)
    {
        return await repository.FindCustomerByEmailAsync(query.Email);
    }
}