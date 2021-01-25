using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Check(IEntity gamer)
        {
            return true;
        }
    }
}
