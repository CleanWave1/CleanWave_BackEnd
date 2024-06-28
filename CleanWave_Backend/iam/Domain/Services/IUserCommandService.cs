using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Domain.Model.Commands;

namespace CleanWave_Backend.iam.Domain.Services;

public interface IUserCommandService
{
    Task<(User user, string token)> Handle(SignInCommand command);

    Task Handle(SignUpCommand command);
}