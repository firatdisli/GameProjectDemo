using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Abstract
{
   public interface IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer);
    }
}
