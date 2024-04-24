using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sign_Identity.API.Filters
{
    public class AuthorizeFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Cookies.TryGetValue("accessToken", out string token))
            {
                context.Result = new BadRequestResult();
                return;
            }

            if (token == null || token == "")
            {
                context.Result = new BadRequestResult();
                return;
            }

            return;
        }
    }
}
