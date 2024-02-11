using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignRentalSupportCard
    {
        public int Id { get; set; }
        public int CampaignRentalSupportDataId { get; set; }
        public int SupportCardId { get; set; }
        public int LimitBreakCount { get; set; }
    }
}
