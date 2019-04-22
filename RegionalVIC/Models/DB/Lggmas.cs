using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Lggmas
    {
        public Lggmas()
        {
            Lggtbl = new HashSet<Lggtbl>();
        }

        public short Seq { get; set; }
        public string Lang { get; set; }
        public string Status { get; set; }

        public ICollection<Lggtbl> Lggtbl { get; set; }
    }
}
