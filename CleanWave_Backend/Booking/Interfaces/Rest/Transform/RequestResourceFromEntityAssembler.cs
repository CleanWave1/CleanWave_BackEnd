using CleanWave_Backend.Booking.Interfaces.Rest.Resources;
using Microsoft.OpenApi.Extensions;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Interfaces.Rest.Transform;

public static class RequestResourceFromEntityAssembler
{
    public static RequestResource ToResourceFromEntity(Request entity)
    {
        return new RequestResource(
            entity.Id,
            entity.ServiceId,
            entity.Name,
            entity.Address,
            entity.Date,
            entity.PaymentStatus.GetDisplayName(),
            entity.ServiceStatus.GetDisplayName());
    }
}