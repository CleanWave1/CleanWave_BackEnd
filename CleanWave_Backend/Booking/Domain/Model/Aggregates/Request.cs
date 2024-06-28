namespace CleanWave_Backend.Booking.Domain.Model.Aggregates;

public partial class Request
{
    public int Id { get; }
    
    public string Name { get; private set; }
    
    public string Address { get; private set; }
    
    public string Date { get; private set; }
    
    public Request(string name, string address, string date) : this()
    {
        Name = name;
        Address = address;
        Date = date;
    }
}