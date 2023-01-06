using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SetNewHallController : ApiController
    {
        // GET: api/SetNewHall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SetNewHall/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SetNewHall
        [HttpPost]
        public bool Post(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            return new BL.SetNewHallBL().SetNewHall(hallToTheHallOwnerDTO);
        }

        // PUT: api/SetNewHall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SetNewHall/5
        public void Delete(int id)
        {
        }
    }
}