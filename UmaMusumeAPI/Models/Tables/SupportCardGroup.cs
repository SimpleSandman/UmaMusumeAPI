using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SupportCardGroup
    {
        public int Id { get; set; }
        public int SupportCardId { get; set; }
        public int CharaId { get; set; }
        public int OutingMax { get; set; }
    }
}
