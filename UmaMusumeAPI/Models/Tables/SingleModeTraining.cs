using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTraining
    {
        public int Id { get; set; }
        public int CommandId { get; set; }
        public int BaseCommandId { get; set; }
        public int CommandLevel { get; set; }
        public int CommandType { get; set; }
        public int CutinFileId { get; set; }
        public int MaxCharaNum { get; set; }
        public int FailureRate { get; set; }
        public int MenuBgId { get; set; }
        public int MenuBgSubId { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public int MotionSet { get; set; }
        public int SaboriType { get; set; }
        public int DressType { get; set; }
        public int DressId { get; set; }
        public int GroupId { get; set; }
    }
}
