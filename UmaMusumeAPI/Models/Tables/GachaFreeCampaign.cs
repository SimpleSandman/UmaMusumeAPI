using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaFreeCampaign
    {
        public int Id { get; set; }
        public int GachaId { get; set; }
        public int TargetDrawType { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
