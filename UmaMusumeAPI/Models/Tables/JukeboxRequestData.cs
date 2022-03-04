using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class JukeboxRequestData
    {
        public int Id { get; set; }
        public int MusicId { get; set; }
        public int RequestType { get; set; }
        public int RequestValue { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
