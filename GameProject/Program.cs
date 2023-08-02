using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());

            //gamerManager.Add(new Gamer
            //{
            //    Id = 1,
            //    BirthYear = 1999,
            //    Name="Umut Can",
            //    SurName="Celik",
            //    IdentityNumber=123456789
            //});





            CustomerManager customerManager = new CustomerManager(new CustomerValidationManager());

            customerManager.Add(new Customer
            {
                Id = 2,
                NationalityId = "123456",
                FirstName = "Eylül",
                LastName = "Biter",
                DateOfBirth = new DateTime(2002, 12, 21),
            });



            GameManager gameManager = new GameManager(new GameValidationManager());

            gameManager.Add(new Game
            {
                Id = 1,
                GameName = "Counter Strike",
                GamePrice = 15,
            });


            CampaignManager campaignManager = new CampaignManager(new CampaignValidationManager());

            campaignManager.Add(new Campaign
            {
                Id = 2,
                CampaignName = "Sale",
                DiscountPercentage = 40,
            }); ;




        }
    }
}