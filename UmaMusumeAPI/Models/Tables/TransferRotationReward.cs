using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TransferRotationReward
    {
        public int Id { get; set; }
        public int RotationId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public int Odds { get; set; }
    }
}
