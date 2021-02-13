using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Abstract
{
 public   interface IGamerService
    {
        public void GamerAdd(Gamer gamer,bool check);
        public void GamerUpdate(Gamer gamer);
        public void GamerDeleted(Gamer gamer);
    }
}
