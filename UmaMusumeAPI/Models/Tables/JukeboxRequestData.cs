namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxRequestData
    {
        public int Id { get; set; }
        public long MusicId { get; set; }
        public long RequestType { get; set; }
        public long RequestValue { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
