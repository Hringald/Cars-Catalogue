using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cars.Data.Models
{
    using static DataConstants.Car;
    public class Car
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public IdentityUser Owner { get; set; }
        [Required]
        [StringLength(OwnerNameMaxLength, MinimumLength = OwnerNameMinLength)]
        public string OwnerName { get; set; }
        public string OwnerId { get; set; }
        [Required]
        [StringLength(MakeNameMaxLength, MinimumLength = MakeNameMinLength)]
        public string Make { get; set; }
        [Required]
        [StringLength(ColorNameMaxLength, MinimumLength = ColorNameMinLength)]
        public string Color { get; set; }
        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        [Range(EngineCubatureMin, EngineCubatureMax)]
        public int EngineCubature { get; set; }
        [Required]
        [Range(HorsePowerMin, HorsePowerMax)]
        public int HorsePower { get; set; }
    }
}
