using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
   public class GetHallsDAL
    {
        public List<HallToTheHallOwner> GetListHall()
        {
            List<HallToTheHallOwner> hallsList = new List<HallToTheHallOwner>();
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    hallsList = ctx.HallToTheHallOwners.Include(s => s.HallOwner).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return hallsList;
        }

        public List<HallToTheHallOwner> GetHallsByEmail(string email)
        {
            using (EventsEntities ctx=new EventsEntities())
            {
                try
                {
                    var c = ctx.HallOwners.Where(hallOwner => hallOwner.Email == email);//.IdHallOwner;
                    List<HallToTheHallOwner> HallsListByOH= (List<HallToTheHallOwner>)ctx.HallToTheHallOwners.Where(hall => hall.Owners == c.FirstOrDefault().Owners);
                    return HallsListByOH;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public static int FilterHallOwnerById(int id)
        {
            using (EventsEntities ctx = new EventsEntities())
            {
                try
                {
                    foreach (HallOwner item in ctx.HallOwners)
                    {
                        if (item.IdHallOwner == id.ToString())
                            return item.Owners;
                    }
                    return 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return 0;
        }

        public static bool InsertNewHall(HallToTheHallOwner newHall)
        {
            //newHall.Owners = id owner hall 
            int owners = FilterHallOwnerById(newHall.Owners);
            if (owners != 0)
                newHall.Owners = owners;
            else
                return false;//HallOwner is'nt exist
            using (EventsEntities ctx = new EventsEntities())
            {
                try
                {
                    ctx.HallToTheHallOwners.Add(newHall);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool UpdateHall(HallToTheHallOwner hall)
        {
            using (EventsEntities ctx=new EventsEntities())
            {
                try
                {
                    ctx.HallToTheHallOwners.Remove(ctx.HallToTheHallOwners.Where(h => h.Hall == hall.Hall).FirstOrDefault());
                    ctx.HallToTheHallOwners.Add(hall);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return false;
        }

    }
}
