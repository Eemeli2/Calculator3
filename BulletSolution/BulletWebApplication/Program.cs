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

#if MOCKED_DATA
builder.Services.AddSingleton<IBulletService, MockBulletService>()
    .AddSingleton<IManufacturerService, EntityManufacturerService>();
#else

builder.Services.AddSingleton<IBulletService, EntityBulletService>()
    .AddSingleton<IMeasurementService, EntityMeasurementService>()
    .AddSingleton<ICaliberService, EntityCaliberService>()
    .AddSingleton<IManufacturerService, EntityManufacturerService>();
#endif





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
