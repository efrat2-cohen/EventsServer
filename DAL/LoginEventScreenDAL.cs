using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginEventScreenDAL
    {
        public bool CheckLoginEvent(string email, string password)
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    var b=ctx.JoysOwners.Where(a => email == a.EmailOwnerJoys && password == a.PasswordOwnerJoys).FirstOrDefault();
                    return b != null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        
        }
        

        public bool IsEmailExist(string email)
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    var b = ctx.JoysOwners.Where(a => email == a.EmailOwnerJoys).FirstOrDefault();
                    return b != null;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
