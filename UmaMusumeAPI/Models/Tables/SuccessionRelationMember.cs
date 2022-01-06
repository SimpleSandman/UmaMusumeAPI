using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SuccessionRelationMember
    {
        public int Id { get; set; }
        public long RelationType { get; set; }
        public long CharaId { get; set; }
    }
}
