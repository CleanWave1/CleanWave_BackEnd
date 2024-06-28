using CleanWave_Backend.iam.Infrastructure.Pipeline.Components;

namespace CleanWave_Backend.iam.Infrastructure.Pipeline.Extensions;

public static class RequestAuthorizationMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestAuthorization(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestAuthorizationMiddleware>();
    }
}