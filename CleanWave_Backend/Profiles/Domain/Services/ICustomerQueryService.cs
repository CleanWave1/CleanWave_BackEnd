using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Queries;

namespace CleanWave_Backend.Profiles.Domain.Services;

public interface ICustomerQueryService
{
    Task<Customer?> Handle(GetCustomerByIdQuery query);
    Task<Customer?> Handle(GetCustomerByEmailQuery query);
}