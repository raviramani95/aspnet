using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContex = await next();

            if(!resultContex.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = resultContex.HttpContext.User.GetUserId();
            var repo = resultContex.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await repo.GetUserByIdAsync(userId);
            // LastActivity == LastActive
            user.LastActivity = DateTime.Now;
            await repo.SaveAllAsync();
        }
    }
}