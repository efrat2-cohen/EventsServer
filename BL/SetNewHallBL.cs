using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SetNewHallBL
    {
        public bool SetNewHall(HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            Converts convert = new Converts();
            return new DAL.SetNewHallDAL().SetNewHall(convert.Convert(hallToTheHallOwnerDTO));
        }


    }
}
