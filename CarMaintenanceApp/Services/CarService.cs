using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class CarService : ICarService
    {
        private static CarService? _instance;
        private CarService() { }

        public static CarService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CarService();
                }
                return _instance;
            }
        }

        public void PerformCarMaintenance(ICar car)
        {
            car.PerformMaintenance();
        }
    }
}