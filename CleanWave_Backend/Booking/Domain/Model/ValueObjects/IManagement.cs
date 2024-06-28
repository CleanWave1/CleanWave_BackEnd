namespace CleanWave_Backend.Booking.Domain.Model.ValueObjects;

public interface IManagement
{
    void IsPaid();

    void IsPending();

    void IsCancelled();

    void IsAccepted();
}