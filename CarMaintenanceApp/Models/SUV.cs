namespace CarMaintenanceApp.Models
{
    public class SUV : ICar
    {
        public void PerformMaintenance()
        {
            Console.WriteLine("Performing maintenance on an SUV.");
        }
    }
}