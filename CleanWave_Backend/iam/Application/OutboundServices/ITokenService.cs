using CleanWave_Backend.iam.Domain.Model.Aggregates;

namespace CleanWave_Backend.iam.Application.OutboundServices;

public interface ITokenService
{
    string GenerateToken(User user);
    Task<int?> ValidateToken(string token);
}