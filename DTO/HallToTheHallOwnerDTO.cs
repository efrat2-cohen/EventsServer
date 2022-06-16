using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HallToTheHallOwnerDTO
    {
        public int Hall { get; set; }
        public int Owners { get; set; }
        public string LocationHall { get; set; }
        public int MaximumNumberOfPlaces { get; set; }
        public int Stars { get; set; }
        public int MinimumPlacesToBook { get; set; }
        public string Remarks { get; set; }
        public string Kashrut { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public Nullable<bool> IsAccessibilityLevel { get; set; }
        public Nullable<bool> IsParking { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string HallName { get; set; }
 
        //public string OwnerName { get; set; }



        //  public virtual HallOwnerDTO HallOwner { get; set; }

    }
}
