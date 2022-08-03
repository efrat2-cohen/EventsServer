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

        public List<DTO.HallToTheHallOwnerDTO> SearchHall(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO, DateTime dateTime, int BasePrice)
        {
            return new BL.SearchHallBL().SearchHalls(hallToTheHallOwnerDTO, dateTime, BasePrice);
        }
        // GET: api/SearchHall
        public List<DTO.HallToTheHallOwnerDTO> Get()
        {
            return new BL.SearchHallBL().GetListHalls(); 
        }

        // GET: api/SearchHall/5
        public string Get(int id)
        {
            return "value";
        }

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
