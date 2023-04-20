using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
   public  class HallDetailsBL
    {
        public static Details GetHall(int id)
        {
            Converts convert = new Converts();
            return new DAL.HallDetailsDal().GetHallDetails(id);
        }
    }
}
