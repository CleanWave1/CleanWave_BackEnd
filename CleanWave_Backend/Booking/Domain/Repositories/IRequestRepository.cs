using CleanWave_Backend.Shared.Domain.Repositories;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Domain.Repositories;

public interface IRequestRepository: IBaseRepository<Request>
{
    //Task<IEnumerable<Request>> FindByReq
}