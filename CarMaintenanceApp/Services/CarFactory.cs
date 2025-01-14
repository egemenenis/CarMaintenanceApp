using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(string carType)
        {
            if (carType == "Sedan")
            {
                return new Sedan();
            }
            else if (carType == "SUV")
            {
                return new SUV();
            }
            else
            {
                throw new ArgumentException("Invalid car type.");
            }
        }
    }
}