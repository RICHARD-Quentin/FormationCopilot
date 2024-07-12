using System.Collections.Generic;
using System.Threading.Tasks;
using YourNamespace.Repositories; // Replace YourNamespace with the actual namespace of your repository

namespace YourNamespace.Services // Replace YourNamespace with the actual namespace of your service
{
    public class CarService
    {
        private readonly CarRepository _carRepository;

        public CarService(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<CarEntity>> GetAllCars()
        {
            return await _carRepository.GetAllCars();
        }

        // Add more methods as needed

        // Example method:
        public async Task<Car> GetCarById(int id)
        {
            return await _carRepository.GetCarById(id);
        }
    }
}