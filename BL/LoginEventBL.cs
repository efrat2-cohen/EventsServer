using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LoginEventBL
    {
        public int LoginEvent(string email, string password)
        {
            return new DAL.LoginEventScreenDAL().CheckLoginEvent(email, password);
        }

        public bool LoginEvent(string email)
        {
            return new DAL.LoginEventScreenDAL().IsEmailExist(email);
        }

    }
}
