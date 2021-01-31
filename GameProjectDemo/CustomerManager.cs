using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CustomerManager
    {
        public void Add(Customer customer,Campaign campaign)
        {
            Console.WriteLine("Sayın "+customer.customerName+" "+customer.CustomerSurname+" üye olarak eklendiniz.");
            Console.WriteLine("Doğum Yılı:"+customer.CustomerDateofBirth);
            Console.WriteLine(campaign.CampaignName+" hesabınıza eklendi.İlk oyununuzu %"+campaign.CampaingDiscountRate+" indirimle satın alabilirsiniz");
        }
        public void PersonVerification(Customer customer)
        {
            if (customer.CustomerTc == 123456) { 
            Console.WriteLine("Tc doğrulandı");
            }
            else { 
                Console.WriteLine("Tcnizi doğru giriniz....");
                Environment.Exit(0);
            }
        }
    }
}
