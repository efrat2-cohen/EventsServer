using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderEvent
    {
        public bool AddEvent(JoysOwnerHall joysOwnerHall)
        {
            try
            {
                using (EventsEntities ctx=new EventsEntities())
                {
                    ctx.JoysOwnerHalls.Add(joysOwnerHall);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteEvent(JoysOwnerHall joysOwnerHall)
        {
            try
            {
                using (EventsEntities ctx=new EventsEntities())
                {
                    ctx.JoysOwnerHalls.Remove(joysOwnerHall);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<JoysOwnerHall> GetOrdersByEventOwner(int id_eventOwner)
        {
            List<JoysOwnerHall> lst = new List<JoysOwnerHall>();
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    lst = ctx.JoysOwnerHalls.Where(joy => joy.Owners == id_eventOwner).ToList();
                    return lst;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public List<JoysOwnerHall> GetOrdersByHallOwner() { }
    }
}
