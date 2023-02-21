using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamer
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt basarisiz.");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit güncellendi.");
        }
    }
}
