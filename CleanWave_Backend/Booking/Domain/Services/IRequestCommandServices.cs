using CleanWave_Backend.Booking.Domain.Model.Commands;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Domain.Services;

public interface IRequestCommandServices
{
    Task<Request?> Handle(CreateRequestCommand command);

}