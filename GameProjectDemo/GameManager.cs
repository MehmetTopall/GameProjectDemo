using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameManager
    {
        public void GameBuy(Customer customer,Campaign campaign,Game game)
        {
            Console.WriteLine("Sayın "+customer.customerName+" "+customer.CustomerSurname+" talebiniz üzere"+game.GameName +" oyunu satın alındı.");
            Console.WriteLine(campaign.CampaignName+" uygulandı.");
            Console.WriteLine("Oyun Fiyatı:"+game.GamePrice+" İndirimli Fiyatı:"+(game.GamePrice - (game.GamePrice * (campaign.CampaingDiscountRate / 100))));
        }
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu "+game.GamePrice+" TL ye sisteme eklendi.");
        }
    }
}
