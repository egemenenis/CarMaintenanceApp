using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public interface IBrandingStrategy
    {
        void PerformBranding(ICar car);
    }
}