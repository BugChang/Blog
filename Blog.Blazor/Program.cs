

using Blog.Blazor;
using Blog.Blazor.Services.Implements;
using Blog.Blazor.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMasaBlazor();
builder.Services.AddDbContext<BlogDbContext>(options => options.UseInMemoryDatabase("blog"));
builder.Services.AddScoped<IArticleService, ArticleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();
