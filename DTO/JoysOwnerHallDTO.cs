using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class JoysOwnerHallDTO
    {
        public int Owners { get; set; }
        public Nullable<System.DateTime> SearchBaseDate { get; set; }
        public Nullable<System.DateTime> SearchCeilingDate { get; set; }
        public Nullable<int> SeveralPlaces { get; set; }
        public Nullable<bool> IsAccessibilityLevel { get; set; }
        public Nullable<bool> IsParking { get; set; }
        public Nullable<System.DateTime> PlacementDate { get; set; }
        public int Hall { get; set; }
        public Nullable<int> CeilingPrice { get; set; }
        public string ChatanName { get; set; }
        public string CalaName { get; set; }
        public string Seminar { get; set; }
        public string YeshivaName { get; set; }

        //public virtual HallOwnerDTO HallOwner { get; set; }
        //public virtual HallToTheHallOwnerDTO HallToTheHallOwner { get; set; }
        //public virtual JoysDTO Joy1 { get; set; }
        //public virtual JoysOwnerDTO JoysOwner { get; set; }
    }
}
