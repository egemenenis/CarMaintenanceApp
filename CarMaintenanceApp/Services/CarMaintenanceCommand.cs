using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public interface ICommand
    {
        void Execute();
    }

    public class CarMaintenanceCommand : ICommand
    {
        private readonly ICar _car;
        private readonly ICarService _carService;

        public CarMaintenanceCommand(ICar car, ICarService carService)
        {
            _car = car;
            _carService = carService;
        }

        public void Execute()
        {
            _carService.PerformCarMaintenance(_car);
            Console.WriteLine($"{_car.GetType().Name} maintenance command executed.");
        }
    }
}