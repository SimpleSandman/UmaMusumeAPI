#nullable disable

namespace UmaMusumeAPI.Models.StoredProcedures
{
    public class SpSuccessionPointSum
    {
        public decimal Parent1Child { get; set; }
        public decimal GrandparentAParent1 { get; set; }
        public decimal GrandparentBParent1 { get; set; }
        public decimal Parent2Child { get; set; }
        public decimal GrandparentAParent2 { get; set; }
        public decimal GrandparentBParent2 { get; set; }
        public decimal Parent1Parent2 { get; set; }
        public decimal PointSum { get; set; }
    }
}
