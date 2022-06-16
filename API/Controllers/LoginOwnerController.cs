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
    public class LoginOwnerController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string email, string password)
        {
            if (new BL.LoginOwnerBL().LoginOwner(email) == true)//email exist->user exist
                if (new BL.LoginOwnerBL().LoginOwner(email, password) == true)
                    return Ok();
                else
                    return Conflict();//wrong password
            return NotFound();//user is not exist
        }
        // GET: api/LoginHall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LoginHall/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoginHall
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LoginHall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LoginHall/5
        public void Delete(int id)
        {
        }
    }
}
