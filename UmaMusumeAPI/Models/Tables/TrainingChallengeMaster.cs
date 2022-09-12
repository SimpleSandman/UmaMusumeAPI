using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingChallengeMaster
    {
        public int Id { get; set; }
        public int TargetMainScenario { get; set; }
        public int ExamId1 { get; set; }
        public int ExamId2 { get; set; }
        public int ExamId3 { get; set; }
        public int ExamId4 { get; set; }
        public int ExamId5 { get; set; }
        public int ExExamId { get; set; }
        public int FreeExamId { get; set; }
        public int ShopId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int StartResultDate { get; set; }
        public int EndResultDate { get; set; }
        public int RentalValue { get; set; }
        public int ConsumeTpRatio { get; set; }
        public int BonusRewardRatio { get; set; }
    }
}
