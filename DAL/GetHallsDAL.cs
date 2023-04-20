using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

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
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public static bool UpdateHall(HallToTheHallOwner hall)
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
