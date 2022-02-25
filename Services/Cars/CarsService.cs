using global::Cars.Data;
using global::Cars.Data.Models;
using global::Cars.Models.Cars;
using System.Collections.Generic;
using System.Linq;

namespace Cars.Services.Cars
{


    public class CarsService : ICarsService
    {
        private readonly CarsDbContext data;
        public CarsService(CarsDbContext data)
        {
            this.data = data;
        }

        public void AddCar(AddCarFormModel car, string userId)
        {
            var carToAdd = new Car
            {
                OwnerName = this.data.Users.FirstOrDefault(u => u.Id == userId).UserName,
                Make = car.Make,
                Model = car.Model,
                LicensePlate = car.LicensePlate,
                EngineCubature = car.EngineCubature,
                Color = car.Color,
                HorsePower = car.HorsePower,
                OwnerId = userId
            };

            this.data.Add(carToAdd);
            this.data.SaveChanges();
        }

        public void EditCar(EditCarFormModel car)
        {
            var carToUpdate = this.data.Cars.FirstOrDefault(c => c.Id == car.Id);

            carToUpdate.Make = car.Make;
            carToUpdate.Model = car.Model;
            carToUpdate.LicensePlate = car.LicensePlate;
            carToUpdate.HorsePower = car.HorsePower;
            carToUpdate.EngineCubature = car.EngineCubature;
            carToUpdate.Color = car.Color;

            this.data.SaveChanges();
        }

        public EditCarFormModel GetCarToEdit(string carId)
        {
            var car = this.data.Cars.FirstOrDefault(c => c.Id == carId);

            var carViewModel = new EditCarFormModel
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                Color = car.Color,
                EngineCubature = car.EngineCubature,
                HorsePower = car.HorsePower,
                LicensePlate = car.LicensePlate
            };

            return carViewModel;
        }

        public AllCarsViewModel GetCars(string searchTerm)
        {
            var carQuery = this.data.Cars.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                carQuery = carQuery.Where(c => c.Make.ToLower().Contains(searchTerm.ToLower()));
            }

            var cars = carQuery
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Color = c.Color,
                    EngineCubature = c.EngineCubature,
                    HorsePower = c.HorsePower,
                    LicensePlate = c.LicensePlate,
                    Make = c.Make,
                    Model = c.Model,
                    OwnerName = c.OwnerName
                }).ToList();

            var carsView = new AllCarsViewModel
            {
                SearchTerm = searchTerm,
                Cars = cars
            };

            return carsView;
        }

        public void DeleteCar(string carId)
        {
            var carToDelete = this.data.Cars.FirstOrDefault(c => c.Id == carId);

            this.data.Remove(carToDelete);
            this.data.SaveChanges();
        }
    }
}