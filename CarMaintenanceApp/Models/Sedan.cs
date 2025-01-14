namespace CarMaintenanceApp.Models
{
    public class Sedan : ICar
    {
        public void PerformMaintenance()
        {
            Console.WriteLine("Performing maintenance on a Sedan.");
        }
    }
}