namespace UmaMusumeAPI.Models.Tables
{
    public class TrainingCuttData
    {
        public int CommandId { get; set; }
        public int SubId { get; set; }
        public int CharaNum { get; set; }
        public int TargetCharaIndex { get; set; }
        public int TargetValue { get; set; }
        public int CuttIndex { get; set; }
        public int SuccessFlg { get; set; }
    }
}
