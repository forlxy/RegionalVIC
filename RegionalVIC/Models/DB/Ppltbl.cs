using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Ppltbl
    {
        public short Yr { get; set; }
        public string LgaCode { get; set; }
        public int Popul { get; set; }
        public decimal Density { get; set; }

        public Lgamas LgaCodeNavigation { get; set; }
    }
}
