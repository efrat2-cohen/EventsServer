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
    public class LoginEventController : ApiController
    {
        // GET: api/Login
        [HttpGet]
        [Route("api/LoginEvent/{email}/{password}")]
        public IHttpActionResult Get(string email, string password)
        {
            if (new BL.LoginEventBL().LoginEvent(email)==true)//email exist->user exist
                if (new BL.LoginEventBL().LoginEvent(email, password)==true)
                    return Ok();
                else
                    return Conflict();//wrong password
            return NotFound();//user is not exist
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
