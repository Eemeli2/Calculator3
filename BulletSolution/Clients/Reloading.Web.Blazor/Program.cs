using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Reloading.Services.EF;
using Reloading.Web.Blazor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IManufacturerService, EntityManufacturerService>();
builder.Services.AddScoped<IBulletService, EntityBulletService>();
builder.Services.AddScoped<IMeasurementService, EntityMeasurementService>();
builder.Services.AddScoped<ICaliberService, EntityCaliberService>();
builder.Services.AddScoped<CaliberViewModel, CaliberViewModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
