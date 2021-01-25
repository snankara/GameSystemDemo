using GameSystemDemo.Concrete;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool Check(IEntity gamer);
    }
}
