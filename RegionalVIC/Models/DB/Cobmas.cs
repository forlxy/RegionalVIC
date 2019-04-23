using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Cobmas
    {
        public Cobmas()
        {
            Cobtbl = new HashSet<Cobtbl>();
            Cmmtbl = new HashSet<Cmmtbl>();
        }

        public short Seq { get; set; }
        public string Cob { get; set; }
        public string Status { get; set; }

        public ICollection<Cobtbl> Cobtbl { get; set; }
        public ICollection<Cmmtbl> Cmmtbl { get; set; }
    }
}
