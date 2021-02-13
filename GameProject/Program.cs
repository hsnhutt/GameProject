using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game
            {
                GameName = "FIFA 21",
                GamePrice = 150
            };
            Game game2 = new Game
            {
                GameName = "NBA 2K21",
                GamePrice = 300
            };

            User user1 = new User
            {
                TcNo = 123456,
                FirstName = "John",
                LastName = "Brown",
                BirthYear = 1995
            };

            User user2 = new User
            {
                TcNo = 654321,
                FirstName = "Jason",
                LastName = "Derulo",
                BirthYear = 1970
            };

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Summer Sale",
                Discount = 20
            };

            UserValidationManager userValidationManager = new UserValidationManager();
            UserManager userManager = new UserManager(userValidationManager);
            userManager.Add(user1);
            if (userValidationManager.Check(user1))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                GameManager gameManager = new GameManager();
                gameManager.Add(game1);
                gameManager.Add(game2);
                Console.WriteLine("");
                Console.WriteLine("");

                CampaignManager campaignManager = new CampaignManager();
                campaignManager.Add(campaign1);
            }
        }

    }
}
