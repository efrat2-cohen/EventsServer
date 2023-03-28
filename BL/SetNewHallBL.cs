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
        //check if posibility delete that
        public bool SetNewHall(HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            return new DAL.SetNewHallDAL().SetNewHall(Converts.ConvertObj(hallToTheHallOwnerDTO));
        }


    }
}