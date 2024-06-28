using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Domain.Model.Queries;
using CleanWave_Backend.iam.Domain.Repositories;
using CleanWave_Backend.iam.Domain.Services;

namespace CleanWave_Backend.iam.Application.QueryServices;

public class UserQueryServices(IUserRepository userRepository) : IUserQueryServices
{
    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }

    public async Task<User?> Handle(GetUserByUsernameQuery query)
    {
        return await userRepository.FindByUsernameAsync(query.Username);
    }
}