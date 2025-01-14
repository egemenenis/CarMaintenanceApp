using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public interface ICarObserver
    {
        void OnMaintenanceCompleted(ICar car);
    }
}