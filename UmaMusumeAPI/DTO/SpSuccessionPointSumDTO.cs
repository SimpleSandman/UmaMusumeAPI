namespace UmaMusumeAPI.DTO
{
    public class SpSuccessionPointSumDTO
    {
        /// <example>1008</example>
        public int Child { get; set; }

        /// <example>1011</example>
        public int Parent1 { get; set; }

        /// <example>1008</example>
        public int Grandparent1A { get; set; }

        /// <example>1009</example>
        public int Grandparent1B { get; set; }

        /// <example>1014</example>
        public int Parent2 { get; set; }

        /// <example>1009</example>
        public int Grandparent2A { get; set; }

        /// <example>1011</example>
        public int Grandparent2B { get; set; }
    }
}
