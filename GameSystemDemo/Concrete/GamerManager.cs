using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Concrete
{
    public class GamerManager : IEntityService<Gamer>
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine("Gamer verified and added: "+ gamer.Name);
            }
            else
            {
                Console.WriteLine("Gamer Not Verified!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Updated");
        }
    }
}
