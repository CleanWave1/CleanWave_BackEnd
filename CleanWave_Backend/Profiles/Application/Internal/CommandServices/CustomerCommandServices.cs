using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Domain.Repositories;
using CleanWave_Backend.Profiles.Domain.Services;
using CleanWave_Backend.Shared.Domain.Repositories;

namespace CleanWave_Backend.Profiles.Application.Internal.CommandServices;

public class CustomerCommandServices(ICustomerRepository repository, IUnitOfWork unitOfWork) : ICustomerCommandService
{
    public async Task<Customer> Handle(CreateCustomerCommand command)
    {
        var customer = new Customer(command);
        try
        {
            await repository.AddSync(customer);
            await unitOfWork.CompleteAsync();
            return customer;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured while creating the customer:  {e.Message}");
            return null;
        }
    }
}