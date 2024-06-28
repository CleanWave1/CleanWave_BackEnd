using CleanWave_Backend.Booking.Domain.Model.Queries;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Domain.Services;

public interface IRequestQueryServices
{
    Task<Request?> Handle(GetRequestByIdQuery query);

    Task<IEnumerable<Request>> Handle(GetAllRequestsQuery query);
}