using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.Services
{
    public class CarMaintenance
    {
        private readonly List<ICarObserver> _observers = new List<ICarObserver>();

        public void AddObserver(ICarObserver observer)
        {
            _observers.Add(observer);
        }

        public void PerformMaintenance(ICar car)
        {
            Console.WriteLine($"{car.GetType().Name} maintenance performed.");

            NotifyObservers(car);
        }

        private void NotifyObservers(ICar car)
        {
            foreach (var observer in _observers)
            {
                observer.OnMaintenanceCompleted(car);
            }
        }
    }
}