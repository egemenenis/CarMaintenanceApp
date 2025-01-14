using CarMaintenanceApp.Models;
using CarMaintenanceApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<ICarService>(CarService.Instance);

builder.Services.AddSingleton<ICarFactory, CarFactory>();

builder.Services.AddTransient<IBrandingStrategy, SedanBrandingStrategy>();
builder.Services.AddTransient<CarMaintenance>();
builder.Services.AddSingleton<ICarObserver, CarOwnerObserver>();

builder.Services.AddTransient<ICommand, CarMaintenanceCommand>(provider =>
{
    var carFactory = provider.GetRequiredService<ICarFactory>();

    // Default value
    var carType = "Sedan";

    ICar car = carFactory.CreateCar(carType);

    var carService = provider.GetRequiredService<ICarService>();
    return new CarMaintenanceCommand(car, carService);
});

builder.Services.AddTransient<CommandInvoker>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();