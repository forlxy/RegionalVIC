using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Cobtbl
    {
        public short Yr { get; set; }
        public string LgaCode { get; set; }
        public string State { get; set; }
        public short CobCode { get; set; }
        public byte Rank { get; set; }
        public int Ppl { get; set; }
        public decimal Percnt { get; set; }
        public int Ttl_ppl { get; set; }

        public Cobmas CobCodeNavigation { get; set; }
        public Lgamas LgaCodeNavigation { get; set; }
        public Sttmas SttCodeNavigation { get; set; }
    }
}
