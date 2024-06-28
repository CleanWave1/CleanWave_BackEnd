namespace CleanWave_Backend.Booking.Domain.Model.ValueObjects;

public record ServiceIdentifier(Guid Identifier)
{
    public ServiceIdentifier(): this(Guid.NewGuid())
    {
        
    }
}