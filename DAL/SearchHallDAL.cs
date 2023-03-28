using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchHallDAL
    {
        public List<HallToTheHallOwner> filterList = new List<HallToTheHallOwner>();
        //searchData.LocationHall = param.location;
        //    searchData.MaximumNumberOfPlaces = param.numGuests;
        //    searchData.Kashrut = param.kashrut;
        //    searchData.IsParking = param.parking;
        //    searchData.IsAccessibilityLevel = param.accessibility;
        public List<HallToTheHallOwner> MenegerSearch(HallToTheHallOwner hallToTheHallOwner, DateTime dateTime)
        {
            Fill();
            if (filterList.Count == 0)
                return null;
            if (dateTime != new DateTime(1, 1, 1))
                FilterDate(dateTime);
            //if (BasePrice != 0)
            //    FilterPriceToPlace(BasePrice);
            if (hallToTheHallOwner != null)
            {
                if (hallToTheHallOwner.LocationHall != null)
                    FilterLocation(hallToTheHallOwner.LocationHall);
                if (hallToTheHallOwner.MaximumNumberOfPlaces != 0)
                    FilterNumOfPlaces(hallToTheHallOwner.MaximumNumberOfPlaces);
                if (hallToTheHallOwner.Kashrut != null)
                    FilterKashrut(hallToTheHallOwner.Kashrut);
                if (hallToTheHallOwner.IsParking != null)
                    FilterParking(hallToTheHallOwner.IsParking);
                if (hallToTheHallOwner.IsAccessibilityLevel != null)
                    FilterAccessibility(hallToTheHallOwner.IsAccessibilityLevel);
                //if (hallToTheHallOwner.HallName != null)
                //    FilterHallName(hallToTheHallOwner);

            }
            return filterList;
        }

        public void Fill()
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    filterList = ctx.HallToTheHallOwners.Include(s => s.HallOwner).ToList();
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

                    foreach (JoysOwnerHall item in ctx.JoysOwnerHalls)
                    {
                        if (item.PlacementDate == date)
                            l.Add(item.Hall);
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
                    if (l[i] != item.Hall)
                        filterList.Remove(item);
                }
            }
        }

        public void FilterLocation(string locationHall)
        {
            for (int i = 0; i < filterList.Count; i++)
            {
                if (filterList[i].LocationHall != locationHall)
                {
                    filterList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void FilterNumOfPlaces(int maxNumOfPlaces)
        {
            int max, min;
            if (maxNumOfPlaces == 200)
            {
                min = 0;
                max = maxNumOfPlaces;
            }
            else
            {
                if (maxNumOfPlaces == 1000)
                {
                    min = 650;
                    max = int.MaxValue;//num of max places in biggest hall.
                }
                else
                {
                    min = maxNumOfPlaces - 150;
                    max = maxNumOfPlaces;
                }
            }

            for (int i = 0; i < filterList.Count; i++)
            {
                if (!(filterList[i].MaximumNumberOfPlaces <= max
                 && filterList[i].MaximumNumberOfPlaces >= min))
                {
                    filterList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void FilterKashrut(string kashrut)
        {
            for (int i = 0; i < filterList.Count; i++)
            {
                if (filterList[i].Kashrut != kashrut)
                {
                    filterList.RemoveAt(i);
                    i--;
                }
            }
            //foreach (HallToTheHallOwner item in filterList)
            //{
            //    if (kashrut != item.Kashrut)
            //        filterList.Remove(item);
            //    if (filterList.Count == 0)
            //        return;
            //}
        }

        public void FilterParking(bool? isParking)
        {
            for (int i = 0; i < filterList.Count; i++)
            {
                if (isParking != filterList[i].IsParking)
                {
                    filterList.RemoveAt(i);
                    i--;
                }
            }
            //foreach (HallToTheHallOwner item in filterList)
            //{
            //    if (isParking != item.IsParking)
            //        filterList.Remove(item);
            //    if (filterList.Count == 0)
            //        return;
            //}
        }

        public void FilterAccessibility(bool? isAccessibilityLevel)
        {
            for (int i = 0; i < filterList.Count; i++)
            {
                if (isAccessibilityLevel != filterList[i].IsAccessibilityLevel)
                {
                    filterList.RemoveAt(i);
                    i--;
                }
            }
            //foreach (HallToTheHallOwner item in filterList)
            //{
            //    if (isAccessibilityLevel != item.IsAccessibilityLevel)
            //        filterList.Remove(item);
            //    if (filterList.Count == 0)
            //        return;
            //}
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


        //temprery - delete
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

        public int GetOwnerByEmail(string email)
        {
            try
            {
                using (EventsEntities ctx=new EventsEntities())
                {
                    return ctx.HallOwners.Where(owner => owner.Email == email).FirstOrDefault().Owners;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<int> GetIdHallsByEmailOwner(string email)
        {
            List<int> idHallsLst = new List<int>();
            int idHall = GetOwnerByEmail(email);
            try
            {
                using (EventsEntities ctx=new EventsEntities())
                {
                    idHallsLst.AddRange(from HallToTheHallOwner item in ctx.HallToTheHallOwners
                                        where item.Owners == idHall
                                        select item.Hall);
                }
                return idHallsLst;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
