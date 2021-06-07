namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeRoute
    {
        public int Id { get; set; }
        public long ScenarioId { get; set; }
        public long CharaId { get; set; }
        public long RaceSetId { get; set; }
    }
}
