using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int TargetGachaId { get; set; }
        public int DispOrder { get; set; }
    }
}
