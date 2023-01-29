using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
   public class SetHall
    {
        public static bool SetNewHall(HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            Converts convert = new Converts();
            return GetHallsDAL.InsertNewHall(convert.Convert(hallToTheHallOwnerDTO));
        }
    }
}
