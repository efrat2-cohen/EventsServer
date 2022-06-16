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
    public class RegisterEventController : ApiController
    {
        // GET: api/RegisterEvent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterEvent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterEvent
        [HttpPost]
        public bool Post(DTO.JoysOwnerDTO joysOwnerDTO)
        {
            return new BL.RegisterEventBL().RegisterEvent(joysOwnerDTO);
        }

        // PUT: api/RegisterEvent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RegisterEvent/5
        public void Delete(int id)
        {
        }
    }
}
