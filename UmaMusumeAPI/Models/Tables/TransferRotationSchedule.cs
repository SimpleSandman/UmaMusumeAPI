using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TransferRotationSchedule
    {
        public int Id { get; set; }
        public int RotationStartDay { get; set; }
        public string RotationStartTime { get; set; }
        public int BaseDate { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
