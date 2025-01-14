using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class SedanBrandingStrategy : IBrandingStrategy
    {
        public void PerformBranding(ICar car)
        {
            Console.WriteLine("Performing sedan branding...");
        }
    }
}