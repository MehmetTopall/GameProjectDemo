using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.GameName = "CsGo";
            game1.GamePrice = 100;
            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yeni Üye Kampanyası";
            campaign1.CampaingDiscountRate = 10;
            CampaignManager campaingManager = new CampaignManager();
            campaingManager.Add(campaign1);

            CustomerManager customerManager = new CustomerManager();
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Customer customer1 = new Customer();
            customer1.CustomerTc =123456;
            customer1.customerName = "Mehmet";
            customer1.CustomerSurname = "Topal";
            customer1.CustomerDateofBirth = 1995;
            customerManager.PersonVerification(customer1);
            customerManager.Add(customer1,campaign1);
            gameManager.GameBuy(customer1,campaign1,game1);
            campaign1.CampaingDiscountRate = 15;
            campaingManager.Update(campaign1);
            campaingManager.Delete(campaign1);
        }
    }
}
