using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo_Odev5.Abstract;
using GameProjectDemo_Odev5.Entities;

namespace GameProjectDemo_Odev5.Concrete
{
    public class CanpaignManager : ICampaignService
    {
        public Game CampaignExecute(Game game,Campaign campaign)
        {
            game.CampaignPrice = campaign.CampaingPrice;
            return game;
        }

        public void CampaignDelete()
        {
            throw new NotImplementedException();
        }

        public void CampaingUpdate()
        {
            throw new NotImplementedException();
        }

    
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignGame+" oyununa "+campaign.CampaingPrice+" kampanyası eklendi");
        }
    }
}
