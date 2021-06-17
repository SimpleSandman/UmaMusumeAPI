namespace UmaMusumeAPI.Models.Tables
{
    public class TrainingCuttCharaData
    {
        public int Id { get; set; }
        public long CommandId { get; set; }
        public long SubId { get; set; }
        public long CharaNum { get; set; }
        public long CharaId { get; set; }
        public long TargetTimeline { get; set; }
        public long TargetListIndex { get; set; }
        public long PropTarget { get; set; }
    }
}
