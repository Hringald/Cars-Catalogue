using Cars.Data;
using System.ComponentModel.DataAnnotations;
namespace Cars.Models.Cars
{
    using static DataConstants.Car;
    public class AddCarFormModel
    {

        [Required]
        [StringLength(MakeNameMaxLength, MinimumLength = MakeNameMinLength)]
        public string Make { get; set; }
        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        [Range(EngineCubatureMin, EngineCubatureMax)]
        public int EngineCubature { get; set; }
        [Required]
        [StringLength(ColorNameMaxLength, MinimumLength = ColorNameMinLength)]
        public string Color { get; set; }
        [Required]
        [Range(HorsePowerMin, HorsePowerMax)]
        public int HorsePower { get; set; }
    }
}