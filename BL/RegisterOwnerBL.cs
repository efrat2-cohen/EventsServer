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
            return new DAL.RegisterOwnerScreenDAL().RegisterOwner(Converts.ConvertObj(hallOwnerDTO));
        }
    }
}
