using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SearchHallBL
    {
        public List<DTO.HallToTheHallOwnerDTO> SearchHalls(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO,DateTime dateTime)
        {
            return Converts.ConvertObj(new DAL.SearchHallDAL().MenegerSearch(Converts.ConvertObj(hallToTheHallOwnerDTO), dateTime));

            //if (new DAL.SearchEventDAL().MenegerSearch(ConvertObj.ConvertObj(hallToTheHallOwnerDTO), dateTime, BasePrice) != null)
            //    return ConvertObj.ConvertObj(new DAL.SearchEventDAL().MenegerSearch(ConvertObj.ConvertObj(hallToTheHallOwnerDTO), dateTime, BasePrice));
            //else return null;
            //return ConvertObj.ConvertObj(new DAL.SearchEventDAL().MenegerSearch(null, dateTime, BasePrice));
        }
        
        //public List<DTO.HallToTheHallOwnerDTO> GetListHalls()
        //{
        //    ConvertObjs ConvertObj = new ConvertObjs();
        //    return ConvertObj.ConvertObj(new DAL.GetHallsDAL().GetListHall());
        //}

        //temrary - delete

        public List<DTO.HallToTheHallOwnerDTO> GetHallsList()
        {
            return Converts.ConvertObj(new DAL.SearchHallDAL().GetListHall());
        }

        //public bool GetInvitedEvent(string email)
        //{
        //    return new DAL.SearchHallDAL().GetListHall();
        //}

        public List<int> GetIdHallsByEmailOwner(string email)
        {
            return new DAL.SearchHallDAL().GetIdHallsByEmailOwner(email);
        }
    }
}
