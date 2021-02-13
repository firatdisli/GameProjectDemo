using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Abstract;
using GameProjectDemo_Odev5.Entities;
namespace GameProjectDemo_Odev5.Concrete
{
    public class SaleMaganer : ISalesService
    {
       

        public void SalesCanceled(Gamer gamer, Game game)
        {
            throw new NotImplementedException();
        }

        public void SalesConfirm(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Firstname + " isimli kullanıcıya " + game.GameName + " oyunu satıldı "+game.CampaignPrice+" TL");
        }
    }
}
