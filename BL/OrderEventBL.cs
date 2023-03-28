using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderEventBL
    {
        public bool AddEvent(JoysOwnerHallDTO joysOwnerHallDTO)
        {
            return new DAL.OrderEvent().AddEvent(Converts.ConvertObj(joysOwnerHallDTO));
        }

        public bool DeleteEvent(JoysOwnerHallDTO joysOwnerHall)
        {
            return new DAL.OrderEvent().DeleteEvent(Converts.ConvertObj(joysOwnerHall));
        }

        public List<JoysOwnerHallDTO> GetOrdersByEventOwner(int id)
        {
            return Converts.ConvertObj(new DAL.OrderEvent().GetOrdersByEventOwner(id));
        }
    }
}
