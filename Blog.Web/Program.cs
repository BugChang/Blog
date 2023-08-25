using Blog.Application.AutoMapper;
using Blog.Application.Interfaces;
using Blog.Application.Services;
using Blog.Domain.Interfaces;
using Blog.EntityFrameworkCore;
using Blog.EntityFrameworkCore.Repository;
using Blog.Web.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new CustomExceptionFilter());
});

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.ViewLocationExpanders.Add(new ThemeViewLocationExpander(builder.Configuration));
});

builder.Services.AddDbContext<BlogDbContext>(options =>
{
    var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

builder.Services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(DtoToEntityProfile));

builder.Services.AddScoped<IAccountAppService, AccountAppService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

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

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetService<BlogDbContext>();
    await dbContext.Database.MigrateAsync();
}
app.Run();
