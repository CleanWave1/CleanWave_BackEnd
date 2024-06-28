using CleanWave_Backend.Booking.Domain.Repositories;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Repositories;
using Request = CleanWave_Backend.Booking.Domain.Model.Aggregates.Request;

namespace CleanWave_Backend.Booking.Infraestructure.Persistence.EFC.Repositories;

public class RequestRepository(AppDbContext context) : BaseRepository<Request>(context), IRequestRepository;
