using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Abstract;
using Game.Concrete;
using Game.Entities;
using MernisServiceReference;

namespace Game.Adapter
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.nationalityIdNo, gamer.firstName.ToUpper(), gamer.lastName.ToUpper(), gamer.dateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
