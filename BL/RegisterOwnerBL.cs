using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RegisterOwnerBL
    {
        public bool RegisterOwner(HallOwnerDTO hallOwnerDTO)
        {
            Converts convert = new Converts();
            return new DAL.RegisterOwnerScreenDAL().RegisterOwner(convert.Convert(hallOwnerDTO));
        }
    }
}
