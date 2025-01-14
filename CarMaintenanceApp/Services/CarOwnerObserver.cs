using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class CarOwnerObserver : ICarObserver
    {
        public void OnMaintenanceCompleted(ICar car)
        {
            Console.WriteLine($"Maintenance for {car.GetType().Name} is completed. Notify the owner.");
        }
    }
}