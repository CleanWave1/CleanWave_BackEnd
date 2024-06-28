using CleanWave_Backend.Booking.Domain.Model.Commands;
using CleanWave_Backend.Booking.Interfaces.Rest.Resources;

namespace CleanWave_Backend.Booking.Interfaces.Rest.Transform;

public static class CreateRequestCommandFromResourceAssembler
{
    public static CreateRequestCommand ToCommandFromResource(CreateRequestResource resource)
    {
        return new CreateRequestCommand(resource.Name, resource.Address, resource.Date);
    }
}