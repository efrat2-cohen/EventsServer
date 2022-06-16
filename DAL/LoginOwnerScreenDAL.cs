using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginOwnerScreenDAL
    {
        public bool CheckLoginOwner(string email, string password)
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    var b = ctx.HallOwners.Where(a => email == a.Email && password == a.PasswordHallOwner).FirstOrDefault();
                    return b != null;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool CheckEmailOwner(string email)
        {
            try
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    var b = ctx.HallOwners.Where(a => email == a.Email).FirstOrDefault();
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
