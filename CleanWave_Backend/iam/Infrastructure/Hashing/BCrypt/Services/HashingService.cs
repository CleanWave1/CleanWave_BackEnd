using CleanWave_Backend.iam.Application.OutboundServices;
using BCryptNet = BCrypt.Net.BCrypt;

namespace CleanWave_Backend.iam.Infrastructure.Hashing.BCrypt.Services;

public class HashingService : IHashingService
{
    public string HashPassword(string password)
    {
        return BCryptNet.HashPassword(password);
    }
    
    public bool VerifyPassword(string password, string passwordHash)
    {
        return BCryptNet.Verify(password, passwordHash);
    }
}