using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using CarBookingProject_0.Components.Account;
using CarBookingProject_0.Data;
using CarBookingProject_0.Domain;
using CarBookingProject_0.Components;


var builder = WebApplication.CreateBuilder(args);

// Configure the database context
builder.Services.AddDbContext<CarBookingProject_0Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarBookingProject_0Context") ??
    throw new InvalidOperationException("Connection string 'CarBookingProject_0Context' not found.")));

// Add Identity services
builder.Services.AddIdentityCore<CarBookingProject_0User>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<CarBookingProject_0Context>()
.AddDefaultTokenProviders();

// Add Razor Pages and Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add Authentication State Provider
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// Add No-Op Email Sender
builder.Services.AddScoped<IEmailSender, IdentityNoOpEmailSender>();


// Add Authentication and Authorization
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
