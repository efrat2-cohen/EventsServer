using DTO;
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

    public class OrderEventController : ApiController
    {
        // GET: api/OrderEvent
        public IHttpActionResult GetOrdersByEventOwner(int id_eventOwner)
        {
            List<JoysOwnerHallDTO> listOwner = new BL.OrderEventBL().GetOrdersByEventOwner(id_eventOwner);
            if (listOwner.Count != 0)
                return Ok(listOwner);
            return Conflict();//does'nt have event to user
        }

        // GET: api/OrderEvent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrderEvent
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OrderEvent/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/OrderEvent/5
        public void Delete(int id)
        {
        }
    }
}
