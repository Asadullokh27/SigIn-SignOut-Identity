using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sign_Identity.API.Filters
{
    public class UpdateResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("Func out");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            
            var routValue = context.HttpContext.Request.Body.ToString();

            if(routValue == null || routValue == "")
            {
                context.Result = new BadRequestResult();
                return;
            }

            return;
        }
    }
}
