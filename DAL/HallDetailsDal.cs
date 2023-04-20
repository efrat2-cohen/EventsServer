using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class Details
    {
        public int HallId { get; set; }
        public HallToTheHallOwner Hall { get; set; }
        public List<DateTime?> placementDateLst  { get; set; }
        public string phoneOwner { get; set; }
      //  public List<HallPriceList> PriceLst { get; set; }
       public Details(int id)
        {
            HallId = id;
            placementDateLst = new List<DateTime?>();
       //     PriceLst = new List<HallPriceList>();
        }
    }
    public class HallDetailsDal
    {//To do: create an object DetailsHall, fields:
     //hallToHallOwner,object hallPrices  basePrice,string phone,(list NameJoys),list placementDate
     //new dh(idHall);
        public Details GetHallDetails(int idHall)
        {
            Details hallDetails = new Details(idHall);

            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                   hallDetails.Hall = ctx.HallToTheHallOwners.First(hd => hd.Hall == idHall);
                   hallDetails.phoneOwner = ctx.HallOwners.First(owner => owner.Owners== hallDetails.Hall.Owners).PhoneNumber;
                   var e = ctx.JoysOwnerHalls.Where(joy => joy.Hall == idHall).ToList();
                    hallDetails.placementDateLst.AddRange(from item in e
                                                          select item.PlacementDate);
             //       hallDetails.PriceLst = ctx.HallPriceLists.Where(joy => joy.Hall == idHall).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return hallDetails;
        }
    }
}
