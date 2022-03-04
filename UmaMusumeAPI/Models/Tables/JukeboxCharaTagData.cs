using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class JukeboxCharaTagData
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int Tag { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
