using System.Collections.Generic;

namespace Cars.Models.Cars
{
    public class AllCarsViewModel
    {
        public string SearchTerm { get; set; }
        public ICollection<CarViewModel> Cars { get; set; }
    }
}