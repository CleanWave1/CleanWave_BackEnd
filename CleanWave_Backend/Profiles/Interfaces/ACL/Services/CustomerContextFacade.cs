using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Domain.Model.Queries;
using CleanWave_Backend.Profiles.Domain.Services;

namespace CleanWave_Backend.Profiles.Interfaces.ACL.Services;

public class CustomerContextFacade(
    ICustomerCommandService customerCommandService,
    ICustomerQueryService customerQueryService): ICustomerContextFacade
{
    public async Task<int> CreateCustomer(string name, string lastName, string email, string phone, string propertyType, string cleaningType,
        string spaceSize, int? numberRooms, string floorType, string instructions)
    {
        var createCustomerCommand = new CreateCustomerCommand(name, lastName, email, phone, propertyType, cleaningType,
            spaceSize, numberRooms, floorType, instructions);
        var customer = await customerCommandService.Handle(createCustomerCommand);
        return customer?.Id ?? 0;
    }

    public async Task<int> FetchCustomerByEmail(string email)
    {
        var getCustomerByEmailQuery = new GetCustomerByEmailQuery(email);
        var customer = await customerQueryService.Handle(getCustomerByEmailQuery);
        return customer?.Id ?? 0;
    }

    public async Task<int> FetchCustomerById(int id)
    {
        var getCustomerByIdQuery = new GetCustomerByIdQuery(id);
        var customer = await customerQueryService.Handle(getCustomerByIdQuery);
        return customer?.Id ?? 0;
    }
}