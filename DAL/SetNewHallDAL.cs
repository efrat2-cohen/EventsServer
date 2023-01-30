using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SetNewHallDAL
    {
        public int FilterHallOwner(int id)
        {
            using (EventsEntities ctx = new EventsEntities())
            {
                try
                {
                    foreach (HallOwner item in ctx.HallOwners)
                    {
                        if (item.IdHallOwner == id.ToString())
                            return item.Owners;
                        return 0;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return 0;
        }
        public bool SetNewHall(HallToTheHallOwner hallToTheHallOwner)
        {
            int code = FilterHallOwner(hallToTheHallOwner.Owners);
            if (code == 0)
                return false;
            hallToTheHallOwner.Owners = code;
            using (EventsEntities ctx = new EventsEntities())
            {
                try
                {
                    ctx.HallToTheHallOwners.Add(hallToTheHallOwner);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}