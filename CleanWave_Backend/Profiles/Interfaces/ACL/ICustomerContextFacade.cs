namespace CleanWave_Backend.Profiles.Interfaces.ACL;

public interface ICustomerContextFacade
{
    Task<int> CreateCustomer(
        string name,
        string lastName,
        string email,
        string phone,
        string propertyType,
        string cleaningType,
        string spaceSize,
        int? numberRooms,
        string floorType,
        string instructions);

    Task<int> FetchCustomerByEmail(string email);
    Task<int> FetchCustomerById(int id);
}