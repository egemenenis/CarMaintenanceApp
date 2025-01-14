using CarMaintenanceApp.Models;
using CarMaintenanceApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarMaintenanceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly ICarFactory _carFactory;

        public CarController(ICarService carService, ICarFactory carFactory)
        {
            _carService = carService;
            _carFactory = carFactory;
        }

        [HttpPost("perform-maintenance")]
        public IActionResult PerformMaintenance([FromBody] string carType)
        {
            ICar car = _carFactory.CreateCar(carType);

            _carService.PerformCarMaintenance(car);

            return Ok($"{carType} maintenance completed.");
        }
    }
}