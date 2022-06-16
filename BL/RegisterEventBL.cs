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
            Converts convert = new Converts();
            return new DAL.RegisterEventScreenDAL().RegisterEvent(convert.Convert(joysOwnerDTO));
        }

       
    }
}
