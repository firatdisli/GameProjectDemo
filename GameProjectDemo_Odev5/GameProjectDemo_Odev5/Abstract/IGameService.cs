using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;
using GameProjectDemo_Odev5.Concrete;

namespace GameProjectDemo_Odev5.Abstract
{
   public interface IGameService
    {
        public void GameAdd(Game game);
        public void GameUpdate(Game game);
        public void GameDeleted(Game game);
    }
}
