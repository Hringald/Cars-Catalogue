using global::Cars.Models.Cars;
using System.Collections.Generic;

namespace Cars.Services.Cars
{


    public interface ICarsService
    {
        public void AddCar(AddCarFormModel car, string userId);
        public void EditCar(EditCarFormModel car);

        public void DeleteCar(string carId);
        public EditCarFormModel GetCarToEdit(string carId);
        public AllCarsViewModel GetCars(string searchTerm);
    }
}