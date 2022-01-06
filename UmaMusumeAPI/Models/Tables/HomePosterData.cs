using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomePosterData
    {
        public int Id { get; set; }
        public long Priority { get; set; }
        public long Height { get; set; }
        public long Width { get; set; }
        public long PosiVertical { get; set; }
        public long PosiHorizontal { get; set; }
        public long DetailValue { get; set; }
        public long UrlValue { get; set; }
        public string Url { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
