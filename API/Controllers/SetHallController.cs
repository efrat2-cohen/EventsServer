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

        // POST: api/SetHall
        [HttpPost]
        public bool Add(DTO.HallToTheHallOwnerDTO hallToTheHallOwnerDTO)
        {
            return BL.SetHall.SetNewHall(hallToTheHallOwnerDTO);
        }

        // POST: api/SetHall
        [HttpPost]
        public IHttpActionResult UpdateHall(DTO.HallToTheHallOwnerDTO hallToTheHallOwner)
        {
            if (BL.SetHall.UpdateHall(hallToTheHallOwner))
                return Ok();
            return Conflict();
        }

        // DELETE: api/SetHall/5
        public void Delete(int id)
        {
        }
    }
}
