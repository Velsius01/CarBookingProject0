using CarBookingProject_0.Data;
using Microsoft.AspNetCore.Identity;

namespace CarBookingProject_0.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<CarBookingProject_0User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<CarBookingProject_0User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
