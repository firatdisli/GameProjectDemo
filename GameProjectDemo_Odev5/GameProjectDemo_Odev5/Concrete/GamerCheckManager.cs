using GameProjectDemo_Odev5.Abstract;
using GameProjectDemo_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo_Odev5.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            if (gamer.YearOfBirth <= 2002)
                return true;
            else
                return false;
        }
    }
}
