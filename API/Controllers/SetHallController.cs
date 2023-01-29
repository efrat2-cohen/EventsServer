using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    public class SetHallController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/SetHall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SetHall/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SetHall
        [HttpPost]
        public bool Post(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            return BL.SetHall.SetNewHall(hallToTheHallOwnerDTO);
        }

        // PUT: api/SetHall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SetHall/5
        public void Delete(int id)
        {
        }
    }
}
