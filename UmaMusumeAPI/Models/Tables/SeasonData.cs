using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SeasonData
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long Season { get; set; }
        public long Priority { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
