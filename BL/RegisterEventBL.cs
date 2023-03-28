using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RegisterEventBL
    {
        public bool RegisterEvent(JoysOwnerDTO joysOwnerDTO)
        {
            return new DAL.RegisterEventScreenDAL().RegisterEvent(Converts.ConvertObj(joysOwnerDTO));
        }

       
    }
}
