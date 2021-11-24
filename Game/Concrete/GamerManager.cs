using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Abstract;
using Game.Entities;

namespace Game.Concrete
{
    public class GamerManager : IGamerService
    {
        private IUserValidationService userValidation;

        public GamerManager(IUserValidationService userValidationService)
        {
            userValidation = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidation.Validation(gamer)==true)
            {
                Console.WriteLine(gamer.firstName + " " + gamer.lastName + " oyuna kaydedildi.");
            }
            else
            {
                Console.WriteLine("Kişi bilgileri doğrulanamadı.");
            }
        }

     
        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }


        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
