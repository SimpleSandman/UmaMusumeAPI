using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class Nickname
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int DispOrder { get; set; }
        public int GroupId { get; set; }
        public int Rank { get; set; }
        public int CharaDataId { get; set; }
        public int UserShow { get; set; }
        public int ReceiveConditionType { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int Type { get; set; }
    }
}
