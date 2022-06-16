using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Converts
    {
        public HallOwnerDTO Convert(HallOwner hallOwner)
        {
            HallOwnerDTO hallOwner_ = new HallOwnerDTO();
            hallOwner_.NameOwners = hallOwner.NameOwners;
            hallOwner_.PhoneNumber = hallOwner.PhoneNumber;
            hallOwner_.CreditCardNumber = hallOwner.CreditCardNumber;
            hallOwner_.Validity = hallOwner.Validity;
            hallOwner_.back3Digits = hallOwner.back3Digits;
            hallOwner_.PasswordHallOwner = hallOwner.PasswordHallOwner;
            hallOwner_.IdHallOwner = hallOwner.IdHallOwner;
            hallOwner_.Email = hallOwner.Email;
            return hallOwner_;
        }

        public HallOwner Convert(HallOwnerDTO hallOwner)
        {
            HallOwner hallOwner_ = new HallOwner();
            hallOwner_.NameOwners = hallOwner.NameOwners;
            hallOwner_.PhoneNumber = hallOwner.PhoneNumber;
            hallOwner_.CreditCardNumber = hallOwner.CreditCardNumber;
            hallOwner_.Validity = hallOwner.Validity;
            hallOwner_.back3Digits = hallOwner.back3Digits;
            hallOwner_.PasswordHallOwner = hallOwner.PasswordHallOwner;
            hallOwner_.IdHallOwner = hallOwner.IdHallOwner;
            hallOwner_.Email = hallOwner.Email;
            return hallOwner_;
        }

        public List<HallOwner> Convert(List<HallOwnerDTO> hallOwner)
        {
            List<HallOwner> hallOwners = new List<HallOwner>();
            foreach (HallOwnerDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<HallOwnerDTO> Convert(List<HallOwner> hallOwner)
        {
            List<HallOwnerDTO> hallOwners = new List<HallOwnerDTO>();
            foreach (HallOwner item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
        public HallPriceListDTO Convert(HallPriceList hallPriceList)
        {
            HallPriceListDTO hallPriceList_ = new HallPriceListDTO();
            hallPriceList_.PriceList = hallPriceList.PriceList;
            hallPriceList_.Owners = hallPriceList.Owners;
            hallPriceList_.Hall = hallPriceList.Hall;
            hallPriceList_.Joy = hallPriceList.Joy;
            hallPriceList_.BasePrice = hallPriceList.BasePrice;
            hallPriceList_.Popularity = hallPriceList.Popularity;
            //if (hallPriceList.HallOwner != null)
            //    hallPriceList_.HallOwner = Convert(hallPriceList.HallOwner);
            //if (hallPriceList.HallToTheHallOwner != null)
            //    hallPriceList_.HallToTheHallOwner = Convert(hallPriceList.HallToTheHallOwner);
            //if (hallPriceList.Joy1 != null)
            //    hallPriceList_.Joy1 = Convert(hallPriceList.Joy1);
            return hallPriceList_;
        }

        public HallPriceList Convert(HallPriceListDTO hallPriceList)
        {
            HallPriceList hallPriceList_ = new HallPriceList();
            hallPriceList_.PriceList = hallPriceList.PriceList;
            hallPriceList_.Owners = hallPriceList.Owners;
            hallPriceList_.Hall = hallPriceList.Hall;
            hallPriceList_.Joy = hallPriceList.Joy;
            hallPriceList_.BasePrice = hallPriceList.BasePrice;
            hallPriceList_.Popularity = hallPriceList.Popularity;
            //if (hallPriceList.HallOwner != null)
            //    hallPriceList_.HallOwner = Convert(hallPriceList.HallOwner);
            //if (hallPriceList.HallToTheHallOwner != null)
            //    hallPriceList_.HallToTheHallOwner = Convert(hallPriceList.HallToTheHallOwner);
            //if (hallPriceList.Joy1 != null)
            //    hallPriceList_.Joy1 = Convert(hallPriceList.Joy1);
            return hallPriceList_;
        }

        public List<HallPriceList> Convert(List<HallPriceListDTO> hallOwner)
        {
            List<HallPriceList> hallOwners = new List<HallPriceList>();
            foreach (HallPriceListDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<HallPriceListDTO> Convert(List<HallPriceList> hallOwner)
        {
            List<HallPriceListDTO> hallOwners = new List<HallPriceListDTO>();
            foreach (HallPriceList item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
        public HallToTheHallOwnerDTO Convert(HallToTheHallOwner hallToTheHallOwner)
        {
            HallToTheHallOwnerDTO hallToTheHallOwner_ = new HallToTheHallOwnerDTO();
            hallToTheHallOwner_.Hall = hallToTheHallOwner.Hall;
            hallToTheHallOwner_.Owners = hallToTheHallOwner.Owners;
            hallToTheHallOwner_.LocationHall = hallToTheHallOwner.LocationHall;
            hallToTheHallOwner_.MaximumNumberOfPlaces = hallToTheHallOwner.MaximumNumberOfPlaces;
            hallToTheHallOwner_.Stars = hallToTheHallOwner.Stars;
            hallToTheHallOwner_.MinimumPlacesToBook = hallToTheHallOwner.MinimumPlacesToBook;
            hallToTheHallOwner_.Remarks = hallToTheHallOwner.Remarks;
            hallToTheHallOwner_.Kashrut = hallToTheHallOwner.Kashrut;
            hallToTheHallOwner_.image1 = hallToTheHallOwner.image1;
            hallToTheHallOwner_.image2 = hallToTheHallOwner.image2;
            hallToTheHallOwner_.image3 = hallToTheHallOwner.image3;
            hallToTheHallOwner_.IsAccessibilityLevel = hallToTheHallOwner.IsAccessibilityLevel;
            hallToTheHallOwner_.IsParking = hallToTheHallOwner.IsParking;
            hallToTheHallOwner_.Street = hallToTheHallOwner.Street;
            hallToTheHallOwner_.City = hallToTheHallOwner.City;
            hallToTheHallOwner_.HallName = hallToTheHallOwner.HallName;
            //if (hallToTheHallOwner.HallOwner != null)
            //    hallToTheHallOwner_.OwnerName  = hallToTheHallOwner.HallName;
            return hallToTheHallOwner_;
        }

        public HallToTheHallOwner Convert(HallToTheHallOwnerDTO hallToTheHallOwner)
        {
            HallToTheHallOwner hallToTheHallOwner_ = new HallToTheHallOwner();
            hallToTheHallOwner_.Hall = hallToTheHallOwner.Hall;
            hallToTheHallOwner_.Owners = hallToTheHallOwner.Owners;
            hallToTheHallOwner_.LocationHall = hallToTheHallOwner.LocationHall;
            hallToTheHallOwner_.MaximumNumberOfPlaces = hallToTheHallOwner.MaximumNumberOfPlaces;
            hallToTheHallOwner_.Stars = hallToTheHallOwner.Stars;
            hallToTheHallOwner_.MinimumPlacesToBook = hallToTheHallOwner.MinimumPlacesToBook;
            hallToTheHallOwner_.Remarks = hallToTheHallOwner.Remarks;
            hallToTheHallOwner_.Kashrut = hallToTheHallOwner.Kashrut;
            hallToTheHallOwner_.image1 = hallToTheHallOwner.image1;
            hallToTheHallOwner_.image2 = hallToTheHallOwner.image2;
            hallToTheHallOwner_.image3 = hallToTheHallOwner.image3;
            hallToTheHallOwner_.IsAccessibilityLevel = hallToTheHallOwner.IsAccessibilityLevel;
            hallToTheHallOwner_.IsParking = hallToTheHallOwner.IsParking;
            hallToTheHallOwner_.Street = hallToTheHallOwner.Street;
            hallToTheHallOwner_.City = hallToTheHallOwner.City;
            hallToTheHallOwner_.HallName = hallToTheHallOwner.HallName;
            //if (hallToTheHallOwner.HallOwner != null)
            //    hallToTheHallOwner_.HallOwner = Convert(hallToTheHallOwner.HallOwner);
            return hallToTheHallOwner_;
        }

        public List<HallToTheHallOwnerDTO> Convert(List<HallToTheHallOwner> hallOwner)
        {
            List<HallToTheHallOwnerDTO> hallOwners = new List<HallToTheHallOwnerDTO>();
            foreach (HallToTheHallOwner item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<HallToTheHallOwner> Convert(List<HallToTheHallOwnerDTO> hallOwner)
        {
            List<HallToTheHallOwner> hallOwners = new List<HallToTheHallOwner>();
            foreach (HallToTheHallOwnerDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
        public Joy Convert(JoysDTO joy)
        {
            Joy joy_ = new Joy();
            joy_.Joy1 = joy.Joy1;
            joy_.NameJoy = joy.NameJoy;
            return joy_;
        }

        public JoysDTO Convert(Joy joy)
        {
            JoysDTO joy_ = new JoysDTO();
            joy_.Joy1 = joy.Joy1;
            joy_.NameJoy = joy.NameJoy;
            return joy_;
        }

        public List<Joy> Convert(List<JoysDTO> hallOwner)
        {
            List<Joy> hallOwners = new List<Joy>();
            foreach (JoysDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<JoysDTO> Convert(List<Joy> hallOwner)
        {
            List<JoysDTO> hallOwners = new List<JoysDTO>();
            foreach (Joy item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
        public JoysOwner Convert(JoysOwnerDTO joysOwner)
        {
            JoysOwner joysOwner_ = new JoysOwner();
            joysOwner_.JoyOwner = joysOwner.JoyOwner;
            joysOwner_.NameOwnerJoy = joysOwner.NameOwnerJoy;
            joysOwner_.EmailOwnerJoys = joysOwner.EmailOwnerJoys;
            joysOwner_.IDOwnerJoys = joysOwner.IDOwnerJoys;
            joysOwner_.PasswordOwnerJoys = joysOwner.PasswordOwnerJoys;
            joysOwner_.PhoneJoysOwner = joysOwner.PhoneJoysOwner;
            return joysOwner_;
        }

        public JoysOwnerDTO Convert(JoysOwner joysOwner)
        {
            JoysOwnerDTO joysOwner_ = new JoysOwnerDTO();
            joysOwner_.JoyOwner = joysOwner.JoyOwner;
            joysOwner_.NameOwnerJoy = joysOwner.NameOwnerJoy;
            joysOwner_.EmailOwnerJoys = joysOwner.EmailOwnerJoys;
            joysOwner_.IDOwnerJoys = joysOwner.IDOwnerJoys;
            joysOwner_.PasswordOwnerJoys = joysOwner.PasswordOwnerJoys;
            joysOwner_.PhoneJoysOwner = joysOwner.PhoneJoysOwner;
            return joysOwner_;
        }

        public List<JoysOwnerDTO> Convert(List<JoysOwner> hallOwner)
        {
            List<JoysOwnerDTO> hallOwners = new List<JoysOwnerDTO>();
            foreach (JoysOwner item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<JoysOwner> Convert(List<JoysOwnerDTO> hallOwner)
        {
            List<JoysOwner> hallOwners = new List<JoysOwner>();
            foreach (JoysOwnerDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
        public JoysOwnerHall Convert(JoysOwnerHallDTO joysOwnerHall)
        {
            JoysOwnerHall joysOwnerHall_ = new JoysOwnerHall();
            joysOwnerHall_.JoyOwnerHall = joysOwnerHall.Owners;
            joysOwnerHall_.SearchBaseDate = joysOwnerHall.SearchBaseDate;
            joysOwnerHall_.SearchCeilingDate = joysOwnerHall.SearchCeilingDate;
            joysOwnerHall_.SeveralPlaces = joysOwnerHall.SeveralPlaces;
            joysOwnerHall_.IsAccessibilityLevel = joysOwnerHall.IsAccessibilityLevel;
            joysOwnerHall_.IsParking = joysOwnerHall.IsParking;
            joysOwnerHall_.PlacementDate = joysOwnerHall.PlacementDate;
            joysOwnerHall_.Hall = joysOwnerHall.Hall;
            joysOwnerHall_.CeilingPrice = joysOwnerHall.CeilingPrice;
            joysOwnerHall_.ChatanName = joysOwnerHall.ChatanName;
            joysOwnerHall_.CalaName = joysOwnerHall.CalaName;
            joysOwnerHall_.Seminar = joysOwnerHall.Seminar;
            joysOwnerHall_.YeshivaName = joysOwnerHall.YeshivaName;
            //   joysOwnerHall_.HallOwner = Convert(joysOwnerHall.HallOwner);
            //if (joysOwnerHall.HallToTheHallOwner != null)
            //    joysOwnerHall_.HallToTheHallOwner = Convert(joysOwnerHall.HallToTheHallOwner);
            //if (joysOwnerHall.Joy1 != null)
            //    joysOwnerHall_.Joy1 = Convert(joysOwnerHall.Joy1);
            //if (joysOwnerHall.JoysOwner != null)
            //    joysOwnerHall_.JoysOwner = Convert(joysOwnerHall.JoysOwner);
            return joysOwnerHall_;
        }

        public JoysOwnerHallDTO Convert(JoysOwnerHall joysOwnerHall)
        {
            JoysOwnerHallDTO joysOwnerHall_ = new JoysOwnerHallDTO();
            joysOwnerHall_.Owners = joysOwnerHall.JoyOwnerHall;
            joysOwnerHall_.SearchBaseDate = joysOwnerHall.SearchBaseDate;
            joysOwnerHall_.SearchCeilingDate = joysOwnerHall.SearchCeilingDate;
            joysOwnerHall_.SeveralPlaces = joysOwnerHall.SeveralPlaces;
            joysOwnerHall_.IsAccessibilityLevel = joysOwnerHall.IsAccessibilityLevel;
            joysOwnerHall_.IsParking = joysOwnerHall.IsParking;
            joysOwnerHall_.PlacementDate = joysOwnerHall.PlacementDate;
            joysOwnerHall_.Hall = joysOwnerHall.Hall;
            joysOwnerHall_.CeilingPrice = joysOwnerHall.CeilingPrice;
            joysOwnerHall_.ChatanName = joysOwnerHall.ChatanName;
            joysOwnerHall_.CalaName = joysOwnerHall.CalaName;
            joysOwnerHall_.Seminar = joysOwnerHall.Seminar;
            joysOwnerHall_.YeshivaName = joysOwnerHall.YeshivaName;
            //  joysOwnerHall_.HallOwner = Convert(joysOwnerHall.HallOwner);
            //if (joysOwnerHall.HallToTheHallOwner != null)
            //    joysOwnerHall_.HallToTheHallOwner = Convert(joysOwnerHall.HallToTheHallOwner);
            //if (joysOwnerHall.Joy1 != null)
            //    joysOwnerHall_.Joy1 = Convert(joysOwnerHall.Joy1);
            //if (joysOwnerHall.JoysOwner != null)
            //    joysOwnerHall_.JoysOwner = Convert(joysOwnerHall.JoysOwner);
            return joysOwnerHall_;
        }
        public List<JoysOwnerHall> Convert(List<JoysOwnerHallDTO> hallOwner)
        {
            List<JoysOwnerHall> hallOwners = new List<JoysOwnerHall>();
            foreach (JoysOwnerHallDTO item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }

        public List<JoysOwnerHallDTO> Convert(List<JoysOwnerHall> hallOwner)
        {
            List<JoysOwnerHallDTO> hallOwners = new List<JoysOwnerHallDTO>();
            foreach (JoysOwnerHall item in hallOwner)
                hallOwners.Add(Convert(item));
            return hallOwners;
        }
    }
}
