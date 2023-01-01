using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTeamRaceSet
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public int RaceInstanceId1 { get; set; }
        public int RaceInstanceId2 { get; set; }
        public int RaceInstanceId3 { get; set; }
        public int RaceInstanceId4 { get; set; }
        public int RaceInstanceId5 { get; set; }
        public int StatusCorrection { get; set; }
        public int SuperTeamCharaId { get; set; }
        public int MotionId { get; set; }
    }
}
