namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxCharaTagData
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long Tag { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
