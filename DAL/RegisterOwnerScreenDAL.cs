using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
                    //try
                    //{
                    //    ctx.HallOwners.Add(hallOwner);
                    //    ctx.SaveChanges();
                    //    return true;
                    //}
                    //catch (Exception)
                    //{
                    //    throw;
                    //}



                    try
                    {
                        ctx.HallOwners.Add(hallOwner);
                        ctx.SaveChanges();
                        return true;
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                }
            }
            return false;
        }
    }
}

