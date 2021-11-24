using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Entities;
using Game.Abstract;
using Game.Concrete;

namespace Game.Concrete
{
    class GameBuyManager : IGameBuyService
    {
        public void Buy(Gamer gamer)
        {
            Console.WriteLine(gamer.firstName + " " + gamer.lastName + " oyun satın aldı.");
        }
    }
}
