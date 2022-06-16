using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HallPriceListDTO
    {
        public int PriceList { get; set; }
        public int Owners { get; set; }
        public int Hall { get; set; }
        public int Joy { get; set; }
        public string BasePrice { get; set; }
        public string Popularity { get; set; }

        //public virtual HallOwnerDTO HallOwner { get; set; }
        //public virtual HallToTheHallOwnerDTO HallToTheHallOwner { get; set; }
        //public virtual JoysDTO Joy1 { get; set; }
    }
}
