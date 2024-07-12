using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models; // Replace "YourNamespace" with the actual namespace of your models

namespace YourNamespace.Repositories // Replace "YourNamespace" with the actual namespace of your repositories
{
    public class CarRepository : ICarRepository // Replace "ICarRepository" with the actual interface name, if applicable
    {
        private readonly YourDbContext _dbContext; // Replace "YourDbContext" with the actual name of your DbContext class

        public CarRepository(YourDbContext dbContext) // Replace "YourDbContext" with the actual name of your DbContext class
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _dbContext.Cars.ToList();
        }

        public Car GetCarById(int id)
        {
            return _dbContext.Cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            _dbContext.Entry(car).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Id == id);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
            }
        }

        // Function to only retrieve red cars
        public IEnumerable<Car> GetRedCars()
        {
            return _dbContext.Cars.Where(c => c.Color == "Red").ToList();
        }
    }
}