using CleanWave_Backend.iam.Domain.Model.Commands;
using CleanWave_Backend.iam.Domain.Model.Queries;
using CleanWave_Backend.iam.Domain.Services;

namespace CleanWave_Backend.iam.Interfaces.ACL.Services;

public class IamContextFacade(IUserCommandService userCommandService,
    IUserQueryServices userQueryServices) : IIamContextFacade
{
    public async Task<int> CreateUser(string username, string password)
    {
        var signUpCommand = new SignUpCommand(username, password);
        await userCommandService.Handle(signUpCommand);
        var getUserByUsernameQuery = new GetUserByUsernameQuery(username);
        var result = await userQueryServices.Handle(getUserByUsernameQuery);
        return result?.Id ?? 0;
    }

    public async Task<int> FetchUserIdByUsername(string username)
    {
        var getUserByUsernameQuery = new GetUserByUsernameQuery(username);
        var result = await userQueryServices.Handle(getUserByUsernameQuery);
        return result?.Id ?? 0;
    }

    public async Task<string> FetchUsernameByUserId(int userId)
    {
        var getUserByIdQuery = new GetUserByIdQuery(userId);
        var result = await userQueryServices.Handle(getUserByIdQuery);
        return result?.Username ?? string.Empty;
    }
}