using CleanWave_Backend.Profiles.Domain.Model.Commands;
using CleanWave_Backend.Profiles.Domain.Model.ValueObjects;

namespace CleanWave_Backend.Profiles.Domain.Model.Aggregates;

public partial class Customer
{
    public int Id { get; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public SpaceDetails Space { get; private set; }

    public Customer()
    {
        Space = new SpaceDetails();
    }
    
    public Customer(string name, string lastName, string email, string phone, 
        string propertyType, 
        string cleaningType,
        string spaceSize,
        int? numberRooms,
        string floorType,
        string instructions)
    {
        Name = name;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Space = new SpaceDetails(propertyType,cleaningType,spaceSize,numberRooms,floorType,instructions);
    }
    
    public Customer(CreateCustomerCommand command)
    {
        Name = command.Name;
        LastName = command.LastName;
        Email = command.Email;
        Phone = command.Phone;
        Space = new SpaceDetails(command.PropertyType, command.CleaningType, command.SpaceSize, command.NumberRooms,
            command.FloorType, command.Instructions);
    }
}