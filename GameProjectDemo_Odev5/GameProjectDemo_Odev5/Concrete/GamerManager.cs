using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Abstract;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Concrete
{
    public class GamerManager : IGamerService
    {
        public void GamerAdd(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void GamerAdd(Gamer gamer, bool check)
        {
            if (check)
            {
                Console.WriteLine(gamer.Firstname + " " + gamer.LastName + " Doğrulanıp eklendi");
            }
            else
                Console.WriteLine(gamer.Firstname + " Doğrulanamadığından Eklenemedi");
        }

        public void GamerDeleted(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void GamerUpdate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
