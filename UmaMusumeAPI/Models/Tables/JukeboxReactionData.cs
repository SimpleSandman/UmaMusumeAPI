namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxReactionData
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long ReactionCharaId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
