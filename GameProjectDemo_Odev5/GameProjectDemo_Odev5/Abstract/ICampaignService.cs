using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Abstract
{
   public interface ICampaignService
    {
        public Game CampaignExecute(Game game, Campaign campaign);
        public void CampaignAdd(Campaign campaign);
        public void CampaingUpdate();
        public void CampaignDelete();

    }
}
