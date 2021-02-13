using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Abstract
{
   public interface ISalesService
    {
        public void SalesConfirm(Gamer gamer,Game game);
        public void SalesCanceled(Gamer gamer, Game game);
    }
}
