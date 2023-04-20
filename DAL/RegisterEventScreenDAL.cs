using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var error in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in error.ValidationErrors)
                            {
                                Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return false;
        }
    }
}
