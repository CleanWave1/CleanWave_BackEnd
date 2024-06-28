using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.Shared.Domain.Repositories;

namespace CleanWave_Backend.iam.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> FindByUsernameAsync(string username);

    bool ExistsByUsername(string username);
}