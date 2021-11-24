using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Entities;


namespace Game.Abstract
{
    interface IGameBuyService
    {
        void Buy(Gamer gamer);
    }
}
