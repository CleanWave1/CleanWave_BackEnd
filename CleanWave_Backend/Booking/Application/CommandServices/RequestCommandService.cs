using CleanWave_Backend.Booking.Domain.Model.Commands;
using CleanWave_Backend.Booking.Domain.Repositories;
using CleanWave_Backend.Booking.Domain.Services;
using CleanWave_Backend.Shared.Domain.Repositories;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Application.CommandServices;

public class RequestCommandService(IRequestRepository requestRepository,
    IUnitOfWork unitOfWork): IRequestCommandServices
{
    public async Task<Request?> Handle(CreateRequestCommand command)
    {
        var request = new Request(command.Name, command.Address, command.Date);
        await requestRepository.AddSync(request);
        await unitOfWork.CompleteAsync();
        return request;
    }
}