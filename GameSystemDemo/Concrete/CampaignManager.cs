using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Concrete
{
    public class CampaignManager : IEntityService<Campaign>
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Updated");
        }
    }
}
