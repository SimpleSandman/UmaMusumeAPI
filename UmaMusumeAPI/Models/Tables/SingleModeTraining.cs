using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTraining
    {
        public int Id { get; set; }
        public long CommandId { get; set; }
        public long BaseCommandId { get; set; }
        public long CommandLevel { get; set; }
        public long CommandType { get; set; }
        public long CutinFileId { get; set; }
        public long MaxCharaNum { get; set; }
        public long FailureRate { get; set; }
        public long MenuBgId { get; set; }
        public long MenuBgSubId { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public long MotionSet { get; set; }
        public long SaboriType { get; set; }
        public long DressType { get; set; }
        public long DressId { get; set; }
    }
}
