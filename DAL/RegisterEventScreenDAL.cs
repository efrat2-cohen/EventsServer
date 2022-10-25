using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegisterEventScreenDAL
    {
        public bool RegisterEvent(JoysOwner joysOwner)
        {
            LoginEventScreenDAL loginEventScreen = new LoginEventScreenDAL();
            if(loginEventScreen.IsEmailExist(joysOwner.EmailOwnerJoys) == false)
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    try
                    {
                        ctx.JoysOwners.Add(joysOwner);
                        ctx.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return false;
        }
    }
}
