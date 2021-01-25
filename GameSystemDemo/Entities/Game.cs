using GameSystemDemo.Abstract;
using GameSystemDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
