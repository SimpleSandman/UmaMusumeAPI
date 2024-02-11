using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ExchangeTicketDetail
    {
        public int Id { get; set; }
        public int CardType { get; set; }
        public int CardId { get; set; }
        public int AdditionalPieceNum { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
