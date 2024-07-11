using Microsoft.AspNetCore.Mvc;

namespace rentCar.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    private static readonly string[] Brand =
    [
        "Opel", "Peugeot", "Citroen", "Kia", "Volkswagen", "Smart", "Lotus", "BMW", "Ferrari", "Toyota"
    ];

    private static readonly string[] Type =
    [
        "Citadine", "Berline", "4x4", "Sport"
    ];

    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCar")]
    public IEnumerable<Car> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Car
        {
            RentalStartDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            RentalEndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index + 7)),
            FuelCharge = Random.Shared.Next(10, 55),
            Horses = Random.Shared.Next(70, 250),
            extraInsurance = false,
            Type = Type[Random.Shared.Next(Type.Length)],
            Brand = Brand[Random.Shared.Next(Brand.Length)]
        })
        .ToArray();
    }


}

