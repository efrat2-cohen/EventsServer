using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SearchHallBL
    {
        public List<DTO.HallToTheHallOwnerDTO> SearchHalls(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO,DateTime dateTime,int BasePrice)
        {
            Converts convert = new Converts();
            if (hallToTheHallOwnerDTO != null)
                if (new DAL.SearchEventDAL().MenegerSearch(convert.Convert(hallToTheHallOwnerDTO), dateTime, BasePrice) != null)
                    return convert.Convert(new DAL.SearchEventDAL().MenegerSearch(convert.Convert(hallToTheHallOwnerDTO), dateTime, BasePrice));
                else return null;
            return convert.Convert(new DAL.SearchEventDAL().MenegerSearch(null, dateTime, BasePrice));
        }
        public List<DTO.HallToTheHallOwnerDTO> GetListHalls()
        {
            Converts convert = new Converts();
            return convert.Convert(new DAL.SearchEventDAL().GetListHall());
        }
    }
}
