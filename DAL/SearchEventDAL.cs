using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchEventDAL
    {
        public List<HallToTheHallOwner> filterList = new List<HallToTheHallOwner>();

        public List<HallToTheHallOwner> MenegerSearch(HallToTheHallOwner hallToTheHallOwner,DateTime dateTime,int BasePrice)
        {
            Fill();
            if(dateTime!=null&&filterList.Count!=0)
                FilterDate(dateTime);
            if (BasePrice != 0&&filterList.Count != 0)
                FilterPriceToPlace(BasePrice);
            if (hallToTheHallOwner != null)
            {
                if (hallToTheHallOwner.LocationHall != null && filterList.Count != 0)
                    FilterLocation(hallToTheHallOwner);
                if (hallToTheHallOwner.MaximumNumberOfPlaces != 0 && filterList.Count != 0)
                    FilterNumOfPlaces(hallToTheHallOwner);
                if (hallToTheHallOwner.IsParking != null && filterList.Count != 0)
                    FilterParking(hallToTheHallOwner);
                if (hallToTheHallOwner.HallName != null && filterList.Count != 0)
                    FilterHallName(hallToTheHallOwner);
                if (hallToTheHallOwner.Kashrut != null && filterList.Count != 0)
                    FilterKashrut(hallToTheHallOwner);
            }
            return filterList;
        }
        public void Fill()
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    filterList = ctx.HallToTheHallOwners.Include (s=>s.HallOwner).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public void Fill2()
        //{
        //    try
        //    {
        //        using (EventsEntities ctx = new EventsEntities())
        //        {
        //            HallOwner h = ctx.HallOwners.Find(1);
        //            ctx.HallOwners.Remove(h);
        //            ctx.Entry(h).State = EntityState.Deleted;
        //            ctx.SaveChanges();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public void FilterDate(DateTime date)
        {
            List<int> l = new List<int>();
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {

                    foreach (JoysOwnerHall item in ctx.JoysOwnerHalls )
                    {
                        if (item.PlacementDate == date)
                            l.Add(item.Hall);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            for (int i = 0; i < l.Count; i++)
            {
                foreach (HallToTheHallOwner item in filterList)
                {
                    if (l[i] == item.Hall)
                        filterList.Remove(item);
                }
            }
        }
        public void FilterLocation(HallToTheHallOwner hallToTheHallOwner)
        {
            foreach (HallToTheHallOwner item in filterList)
            {
                if (item.LocationHall != hallToTheHallOwner.LocationHall)
                    filterList.Remove(item);
                if (filterList.Count == 0)
                    return;
            }
        }

        public void FilterNumOfPlaces(HallToTheHallOwner hallToTheHallOwner)
        {
            foreach (HallToTheHallOwner item in filterList)
            {
                if (item.MaximumNumberOfPlaces < hallToTheHallOwner.MaximumNumberOfPlaces
                    || item.MinimumPlacesToBook > hallToTheHallOwner.MaximumNumberOfPlaces)
                    filterList.Remove(item);
                if (filterList.Count == 0)
                    return;
            }
        }

        public void FilterParking(HallToTheHallOwner hallToTheHallOwner)
        {
            foreach (HallToTheHallOwner item in filterList)
            {
                if (hallToTheHallOwner.IsParking != item.IsParking)
                    filterList.Remove(item);
                if (filterList.Count == 0)
                    return;
            }
        }

        public void FilterHallName(HallToTheHallOwner hallToTheHallOwner)
        {
            foreach (HallToTheHallOwner item in filterList)
            {
                if (hallToTheHallOwner.HallName != item.HallName)
                    filterList.Remove(item);
                if (filterList.Count == 0)
                    return;

            }
        }

        public void FilterKashrut(HallToTheHallOwner hallToTheHallOwner)
        {
            foreach (HallToTheHallOwner item in filterList)
            {
                if (hallToTheHallOwner.Kashrut != item.Kashrut)
                    filterList.Remove(item);
                if (filterList.Count == 0)
                    return;
            }
        }

        public void FilterPriceToPlace(int BasePrice)
        {
            List<int> l = new List<int>();
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    foreach (HallPriceList item in ctx.HallPriceLists)
                    {
                        if (item.BasePrice != BasePrice.ToString())
                            l.Add(item.Hall);
                        if (filterList.Count == 0)
                            return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            for (int i = 0; i < l.Count; i++)
            {
                foreach (HallToTheHallOwner item in filterList)
                {
                    if (l[i] == item.Hall)
                        filterList.Remove(item);
                    if (filterList.Count == 0)
                        return;
                }
            }
        }

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
    }
}
