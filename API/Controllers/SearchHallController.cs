using API.Helpers;
using Newtonsoft.Json;
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

        [HttpGet]
        public List<DTO.HallToTheHallOwnerDTO> GetHallsList()
        {
            var x = new BL.SearchHallBL().GetHallsList();
            return x;
        }

        [HttpGet]
        //[Route("SearchHall/GetNamesHallByOwner")]
        public IHttpActionResult GetNamesHallByOwner(string emailOwner)
        {
            var lst = new BL.SearchHallBL().GetIdHallsByEmailOwner(emailOwner);

            List<NamesHalls> lstExmple = new List<NamesHalls>();
            lstExmple.Add(new NamesHalls("58", 1));
            lstExmple.Add(new NamesHalls("grand hall", 2));
            return Ok(lstExmple);
        }

        // POST: api/SearchHall
        public void Post([FromBody] string value)
        {
        }

        // DELETE: api/SearchHall/5
        public void Delete(int id)
        {
        }
    }


}
