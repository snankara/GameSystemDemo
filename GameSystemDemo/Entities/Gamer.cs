using GameSystemDemo.Abstract;
using GameSystemDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        
    }
}
