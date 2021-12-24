namespace UmaMusumeAPI.Models.Tables
{
    public class TrainingChallengeMaster
    {
        public int Id { get; set; }
        public long TargetMainScenario { get; set; }
        public long ExamId1 { get; set; }
        public long ExamId2 { get; set; }
        public long ExamId3 { get; set; }
        public long ExamId4 { get; set; }
        public long ExamId5 { get; set; }
        public long ExExamId { get; set; }
        public long FreeExamId { get; set; }
        public long ShopId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public long StartResultDate { get; set; }
        public long EndResultDate { get; set; }
    }
}
