using Game.Entities;
using Game.Abstract;
using Game.Concrete;
using Game.Adapter;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {id=1, firstName="Hamit", lastName="Bozdağ", nationalityIdNo=52516400508, dateOfBirth=new DateTime(1989,10,2)};
            Gamer gamer1 = new Gamer() { id = 2, firstName = "Ali", lastName = "Tek", nationalityIdNo = 52516400508, dateOfBirth = new DateTime(2004, 10, 2) };

            IGamerService gamerManager = new GamerManager(new MernisServiceAdapter());

            gamerManager.Add(gamer);

            IGameBuyService gameBuyService = new GameBuyManager();
            gameBuyService.Buy(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add();
            
        }
    }
}
