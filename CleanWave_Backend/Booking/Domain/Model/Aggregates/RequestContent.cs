using CleanWave_Backend.Booking.Domain.Model.ValueObjects;

namespace CleanWave_Backend.Booking.Domain.Model.Aggregates;

public partial class Request: IManagement
{
    public ServiceIdentifier ServiceId { get; private set; }
    public EPaymentStatus PaymentStatus { get; protected set; }
    public EServiceStatus ServiceStatus { get; protected set; }

    public Request()
    {
        Name = string.Empty;
        Address = string.Empty;
        Date = string.Empty;
        PaymentStatus = EPaymentStatus.Paid;
        ServiceStatus = EServiceStatus.Accepted;
        ServiceId = new ServiceIdentifier();
    }
    
    public void IsPaid()
    {
        PaymentStatus = EPaymentStatus.Paid;
    }

    public void IsPending()
    {
        PaymentStatus = EPaymentStatus.Pending;
    }

    public void IsCancelled()
    {
        ServiceStatus = EServiceStatus.Canceled;
    }

    public void IsAccepted()
    {
        ServiceStatus = EServiceStatus.Accepted;
    }
}