using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class SUVBrandingStrategy : IBrandingStrategy
    {
        public void PerformBranding(ICar car)
        {
            Console.WriteLine("Performing SUV branding...");
        }
    }
}