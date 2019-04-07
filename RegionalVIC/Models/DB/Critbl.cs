using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Critbl
    {
        public string LgaCode { get; set; }
        public short YrEnd { get; set; }
        public string PolRegion { get; set; }
        public int IncdRcd { get; set; }
        public decimal RatePerPpl { get; set; }
        public decimal Rate { get; set; }

        public Lgamas LgaCodeNavigation { get; set; }
    }
}
