using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Concrete
{
    public class GameManager : IEntityService<Game>
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Updated");
        }

        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Game name : "+game.Name+ ", Game price : " +game.Price+ ", Gamer name : " + gamer.Name + ", Campaign name : " + campaign.Name + ", Discount : " + campaign.Discount + ", Total : " + (game.Price - campaign.Discount * game.Price));
        }
    }
}
