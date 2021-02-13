using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;
using GameProjectDemo_Odev5.Abstract;

namespace GameProjectDemo_Odev5.Concrete
{
    public class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu eklendi");
        }

        public void GameDeleted(Game game)
        {
            throw new NotImplementedException();
        }

        public void GameUpdate(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
