using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public interface ICarFactory
    {
        ICar CreateCar(string carType);
    }
}