using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsNewsTrainerDetail
    {
        public int Id { get; set; }
        public long TrainerTextGroup { get; set; }
        public long TextNumber { get; set; }
        public long ResourceId { get; set; }
    }
}
