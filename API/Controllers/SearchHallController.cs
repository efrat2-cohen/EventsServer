using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace API.Controllers
{
    public class SearchHallController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        [HttpPost]
        //[Route("api/FilterHalls")]
        public List<DTO.HallToTheHallOwnerDTO> FilterHalls([FromBody] JObject obj)
        {
            //int basePrice = param.num;

            dynamic param = obj;
            DTO.HallToTheHallOwnerDTO searchData = new DTO.HallToTheHallOwnerDTO();
            searchData.LocationHall = param.location;
            searchData.MaximumNumberOfPlaces = param.numGuests;
            searchData.Kashrut = param.kashrut;
            searchData.IsParking = param.parking;
            searchData.IsAccessibilityLevel = param.accessibility;
            DateTime dateTime;
            if (param.date != null)
                dateTime = param.date;
            else
                dateTime = new DateTime(1, 1, 1);

            //DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO=obj.
            //   , DateTime dateTime=
            //     int BasePrice
            return new BL.SearchHallBL().SearchHalls(searchData, dateTime);
        }

        //[Route("api/SearchHall/Get")]
        //public IHttpActionResult Get()
        //{
        //    return Ok();
        //}
        // GET: api/SearchHall

        [HttpGet]
        public List<DTO.HallToTheHallOwnerDTO> GetHallsList()
        {
            var x = new BL.SearchHallBL().GetHallsList();
            return x;
        }

        [HttpGet]
        //public List<object> GetHallsByOwner(string email_owner)
        //{
        //    List < List<object> > hallsLst;
        //    List<int> idHallLst = new BL.SearchHallBL().GetIdHallsByEmailOwner(email_owner);
        //    foreach (int item in idHallLst)
        //    {
        //        hallsLst.Add(GetDetailsHallByHall(item))
        //    }
        //}

        public List<object> GetDetailsHallByHall(int id_hall)
        {
            List<object> lst = new List<object>();
            lst.Add(new DTO.HallToTheHallOwnerDTO());
            lst.Add(new DTO.HallPriceListDTO());
            lst.Add(new DTO.HallOwnerDTO());
            return lst;
        }
        // POST: api/SearchHall
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SearchHall/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/SearchHall/5
        public void Delete(int id)
        {
        }
    }
}
