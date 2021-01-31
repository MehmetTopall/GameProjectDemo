using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" sisteme eklendi. "+"İndirim oranı "+"%"+campaign.CampaingDiscountRate);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Silindi");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " güncellendi");
            Console.WriteLine("Yeni indirim oranı %"+campaign.CampaingDiscountRate);
        }
    }
}
