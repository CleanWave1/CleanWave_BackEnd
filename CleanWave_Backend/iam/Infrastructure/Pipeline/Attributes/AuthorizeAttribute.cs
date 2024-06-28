using CleanWave_Backend.iam.Domain.Model.Aggregates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanWave_Backend.iam.Infrastructure.Pipeline.Attributes;

public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();

        if (allowAnonymous)
        {
            Console.WriteLine(" Skipping authorization");
            return;
        }

        // verify if user is logged in by checking if HttpContext.User is set
        var user = (User?)context.HttpContext.Items["User"];

        // if user is not logged in then return 401 status code
        if (user == null) context.Result = new UnauthorizedResult();
    }
}