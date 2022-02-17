using BulletLibrary.Interfaces;
using Reloading.Services;
using Reloading.Services.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
        {
            options.CustomSchemaIds(type => type.ToString());
            options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
        }
    );

builder.Services.AddSingleton<IBulletService, MockBulletService>()
    .AddSingleton<IManufacturerService, EntityManufacturerService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
