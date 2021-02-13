using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Has Arrived! Don't Miss Opportunities!!!!   Discount is : " + campaign.Discount);
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Has Updated! New Discount is : " + campaign.Discount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Has Been Deleted !!!");
        }
    }
}
