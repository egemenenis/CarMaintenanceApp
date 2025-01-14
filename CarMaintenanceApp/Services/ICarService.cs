using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public interface ICarService
    {
        void PerformCarMaintenance(ICar car);
    }
}