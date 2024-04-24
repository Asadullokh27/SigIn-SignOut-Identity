
using System.Net.Security;
using System.Security.Claims;

namespace Sign_Identity.API.Filters
{
    public class AnyEndPointFilter : Attribute, IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            Console.WriteLine("Hello World");

            await next(context);

            
            return null;
        }
    }
}
