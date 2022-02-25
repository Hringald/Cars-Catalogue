using Cars.Data;
using Cars.Infrastructure;
using Cars.Models;
using Cars.Models.Cars;
using Cars.Services.Cars;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Cars.Controllers
{
    using static DataConstants.Car;
    public class CarsController : Controller
    {
        private readonly ICarsService carsService;
        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }
        [Authorize]
        public IActionResult ViewCars(string searchTerm)
        {
            var carsView = this.carsService.GetCars(searchTerm);


            return View(carsView);
        }
        [Authorize]
        public IActionResult AddCar()
        {

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddCar(AddCarFormModel car)
        {
            if (string.IsNullOrEmpty(car.Make) || car.Make.Length < MakeNameMinLength || car.Make.Length > MakeNameMaxLength)
            {
                ModelState.AddModelError("Make", $"Make is required and has to be between {MakeNameMinLength} and {MakeNameMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.Color) || car.Color.Length < ColorNameMinLength || car.Color.Length > ColorNameMaxLength)
            {
                ModelState.AddModelError("Color", $"Color is required and has to be between {ColorNameMinLength} and {ColorNameMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.Model) || car.Model.Length < ModelMinLength || car.Model.Length > ModelMaxLength)
            {
                ModelState.AddModelError("Model", $"Model is required and has to be between {ModelMinLength} and {ModelMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.LicensePlate))
            {
                ModelState.AddModelError("LicensePlate", $"License Plate is required.");
            }
            if (car.EngineCubature < EngineCubatureMin || car.EngineCubature > EngineCubatureMax)
            {
                ModelState.AddModelError("EngineCubature", $"Engine Cubature must be between {EngineCubatureMin} and {EngineCubatureMax}");
            }
            if (car.HorsePower < HorsePowerMin || car.HorsePower > HorsePowerMax)
            {
                ModelState.AddModelError("HorsePower", $"HorsePower must be between {HorsePowerMin} and {HorsePowerMax}");
            }

            if (ModelState.IsValid)
            {
                this.carsService.AddCar(car, this.User.GetId());
            }

            return this.Redirect("/Cars/ViewCars");
        }
        [Authorize]
        public IActionResult EditCar(string carId)
        {

            var carViewModel = this.carsService.GetCarToEdit(carId);


            return View(carViewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditCar(EditCarFormModel car)
        {
            if (string.IsNullOrEmpty(car.Make) || car.Make.Length < MakeNameMinLength || car.Make.Length > MakeNameMaxLength)
            {
                ModelState.AddModelError("Make", $"Make is required and has to be between {MakeNameMinLength} and {MakeNameMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.Color) || car.Color.Length < ColorNameMinLength || car.Color.Length > ColorNameMaxLength)
            {
                ModelState.AddModelError("Color", $"Color is required and has to be between {ColorNameMinLength} and {ColorNameMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.Model) || car.Model.Length < ModelMinLength || car.Model.Length > ModelMaxLength)
            {
                ModelState.AddModelError("Model", $"Model is required and has to be between {ModelMinLength} and {ModelMaxLength} characters.");
            }
            if (string.IsNullOrEmpty(car.LicensePlate))
            {
                ModelState.AddModelError("LicensePlate", $"License Plate is required.");
            }
            if (car.EngineCubature < EngineCubatureMin || car.EngineCubature > EngineCubatureMax)
            {
                ModelState.AddModelError("EngineCubature", $"Engine Cubature must be between {EngineCubatureMin} and {EngineCubatureMax}");
            }
            if (car.HorsePower < HorsePowerMin || car.HorsePower > HorsePowerMax)
            {
                ModelState.AddModelError("HorsePower", $"HorsePower must be between {HorsePowerMin} and {HorsePowerMax}");
            }

            if (ModelState.IsValid)
            {
                this.carsService.EditCar(car);
            }

            return this.Redirect("/Cars/ViewCars");
        }


        [Authorize]
        [HttpGet]
        public IActionResult DeleteCar(string carId)
        {
            this.carsService.DeleteCar(carId);

            return this.Redirect("/Cars/ViewCars");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
