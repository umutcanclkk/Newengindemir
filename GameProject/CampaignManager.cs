using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        ICampaignValidationService _validationService;

        public CampaignManager(ICampaignValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Campaign campaign)
        {
            if (_validationService.Validate(campaign) == true)
            {
                Console.WriteLine("Kampanya Eklendi");
            }
            else
            {
                Console.WriteLine("Kampanya Eklenemedei");
            }
        }


        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi" + "" + campaign.DiscountPercentage);
        }


        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi" + "" + campaign.DiscountPercentage);
        }
    }
}
