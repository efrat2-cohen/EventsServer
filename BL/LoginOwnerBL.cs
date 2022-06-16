using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LoginOwnerBL
    {
        public bool LoginOwner(string email, string password)
        {
            return new DAL.LoginOwnerScreenDAL().CheckLoginOwner(email, password);
        }

        public bool LoginOwner(string email)
        {
            return new DAL.LoginOwnerScreenDAL().CheckEmailOwner(email);
        }

    }
}
