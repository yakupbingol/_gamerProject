using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UsersValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 2000 && gamer.FirstName == "Yakup" && gamer.LastName=="Bingöl" && 
                gamer.IdentityNumber == 192021)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
