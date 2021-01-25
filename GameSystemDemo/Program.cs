using GameSystemDemo.Abstract;
using GameSystemDemo.Concrete;
using GameSystemDemo.Entities;
using System;

namespace GameSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();

            Gamer gamer = new Gamer {Id = 1, Name = "Eyüp", LastName = "Gencer", DateOfBirth = "1994", NationalityId = "123456789" };
            Game game = new Game {Id = 1, Name = "Forza Horizon 4", Price = 210.49 };
            Campaign campaign = new Campaign {Id = 1, Name = "Campaign", Discount = 0.15 };


            //gamerManager.Add(gamer);
            //gamerManager.Delete(gamer);
            //gamerManager.Update(gamer);

            //campaignManager.Add(campaign);
            //campaignManager.Delete(campaign);
            //campaignManager.Update(campaign);

            //gameManager.Add(game);
            //gameManager.Delete(game);
            //gameManager.Update(game);
            gameManager.Sell(game,gamer,campaign);

        }
    }
}
