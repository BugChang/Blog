using Blog.Web.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddScoped<IViewLocationExpander, ThemeViewLocationExpander>();

builder.Services.AddControllersWithViews();

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationExpanders.Add(new ThemeViewLocationExpander(builder.Configuration));
});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();


var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute("areaRoute", "Console",
        "Console/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapDefaultControllerRoute();
});

app.Run();
