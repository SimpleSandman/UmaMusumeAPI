using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharaType
    {
        public string Id { get; set; }
        public int CharaId { get; set; }
        public int TargetScene { get; set; }
        public int TargetCut { get; set; }
        public int TargetType { get; set; }
        public int Value { get; set; }
    }
}
