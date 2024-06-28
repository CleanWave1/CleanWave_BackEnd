using CleanWave_Backend.Booking.Domain.Model.Queries;
using CleanWave_Backend.Booking.Domain.Repositories;
using CleanWave_Backend.Booking.Domain.Services;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Application.QueryServices;

public class RequestQueryService(IRequestRepository requestRepository) : IRequestQueryServices
{
    public async Task<Request?> Handle(GetRequestByIdQuery query)
    {
        return await requestRepository.FindByIdAsync(query.RequestId);
    }

    public async Task<IEnumerable<Request>> Handle(GetAllRequestsQuery query)
    {
        return await requestRepository.ListAsync();
    }
}