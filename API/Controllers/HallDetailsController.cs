using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    public class HallDetailsController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: HallDetails
        [HttpGet]
        public IHttpActionResult GetHallById(int id)
        {
            var x = BL.HallDetailsBL.GetHall(id);
            if (x != null)
            return Ok(x);
            return Conflict();

        }
    }
}
