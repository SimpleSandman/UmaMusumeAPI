using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomePosterData
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int PosiVertical { get; set; }
        public int PosiHorizontal { get; set; }
        public int DetailValue { get; set; }
        public int UrlValue { get; set; }
        public string Url { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
