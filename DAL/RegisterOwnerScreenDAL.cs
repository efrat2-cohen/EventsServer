﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegisterOwnerScreenDAL
    {
        public bool RegisterOwner(HallOwner hallOwner)
        {
            LoginOwnerScreenDAL loginOwnerScreen = new LoginOwnerScreenDAL();
            if(loginOwnerScreen.CheckEmailOwner(hallOwner.Email) == false)
            {
                using (EventsEntities ctx = new EventsEntities())
                {
                    try
                    {
                        ctx.HallOwners.Add(hallOwner);
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

