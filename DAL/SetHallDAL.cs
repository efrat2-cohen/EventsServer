using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SetHallDAL
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

        public static bool UpdateHall(HallToTheHallOwner hallToTheHallOwner)
        {
            using (EventsEntities ctx = new EventsEntities())
            {
                try
                {
                    HallToTheHallOwner updateHall = ctx.HallToTheHallOwners.FirstOrDefault(hall => hall.Hall == hallToTheHallOwner.Hall);
                    if (updateHall!=null)
                    {
                        updateHall.HallName = hallToTheHallOwner.HallName;
                        updateHall.HallOwner = hallToTheHallOwner.HallOwner;
                        updateHall.HallPriceLists = hallToTheHallOwner.HallPriceLists;
                        updateHall.image1 = hallToTheHallOwner.image1;
                        updateHall.image2 = hallToTheHallOwner.image2;
                        updateHall.image3 = hallToTheHallOwner.image3;
                        updateHall.IsAccessibilityLevel = hallToTheHallOwner.IsAccessibilityLevel;
                        updateHall.IsParking = hallToTheHallOwner.IsParking;
                        updateHall.JoysOwnerHalls = hallToTheHallOwner.JoysOwnerHalls;
                        updateHall.Kashrut = hallToTheHallOwner.Kashrut;
                        updateHall.MaximumNumberOfPlaces = hallToTheHallOwner.MaximumNumberOfPlaces;
                        updateHall.MinimumPlacesToBook = hallToTheHallOwner.MinimumPlacesToBook;
                        updateHall.Remarks = hallToTheHallOwner.Remarks;
                        updateHall.Stars = hallToTheHallOwner.Stars;
                        updateHall.City = hallToTheHallOwner.City;
                        updateHall.Street = hallToTheHallOwner.Street;
                        ctx.SaveChanges();
                    }
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