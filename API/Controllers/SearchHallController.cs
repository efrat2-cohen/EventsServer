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
            dynamic param = obj;
            //DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO = param.hall;
            DateTime dateTime = param.date;
            int BasePrice = param.num;
            //DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO=obj.
            //   , DateTime dateTime=
            //     int BasePrice
            DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO = null;
            return new BL.SearchHallBL().SearchHalls(hallToTheHallOwnerDTO, dateTime, BasePrice);
        }
       
        //[Route("api/SearchHall/Get")]
        //public IHttpActionResult Get()
        //{
        //    return Ok();
        //}
        // GET: api/SearchHall

        [HttpGet]
        public List<DTO.HallToTheHallOwnerDTO> Get()
        {
            var x = new BL.SearchHallBL().GetListHalls();
            return x;
        }

        // GET: api/SearchHall/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/SearchHall
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SearchHall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SearchHall/5
        public void Delete(int id)
        {
        }
    }
}
