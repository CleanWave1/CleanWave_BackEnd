using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Domain.Model.Queries;

namespace CleanWave_Backend.iam.Domain.Services;

public interface IUserQueryServices
{
    Task<User?> Handle(GetUserByIdQuery query);
    Task<IEnumerable<User>> Handle(GetAllUsersQuery query);
    Task<User?> Handle(GetUserByUsernameQuery query);
}