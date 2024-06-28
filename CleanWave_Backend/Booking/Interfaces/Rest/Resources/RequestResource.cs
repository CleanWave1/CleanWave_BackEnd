using CleanWave_Backend.Booking.Domain.Model.ValueObjects;

namespace CleanWave_Backend.Booking.Interfaces.Rest.Resources;

public record RequestResource(
    int Id,
    ServiceIdentifier ServiceId,
    string Name,
    string Address,
    string Date,
    string PaymentStatus,
    string ServiceStatus);