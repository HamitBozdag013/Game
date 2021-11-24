using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Abstract;

namespace Game.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("2. Satışa %50 Kampanyası eklendi.");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
