using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignValidationManager : ICampaignValidationService
    {
        public bool Validate(Campaign campaign)
        {
            if (campaign.Id == 2 && campaign.CampaignName == "Sale" && campaign.DiscountPercentage == 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
