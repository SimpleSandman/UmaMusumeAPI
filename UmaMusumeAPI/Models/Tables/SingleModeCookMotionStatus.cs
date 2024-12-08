using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookMotionStatus
    {
        public int Id { get; set; }
        public int TurnProgress { get; set; }
        public int GardenProgress { get; set; }
        public int MotionId1 { get; set; }
        public int MotionId2 { get; set; }
    }
}