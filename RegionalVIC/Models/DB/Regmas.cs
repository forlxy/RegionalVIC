using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Regmas
    {
        public short Seq { get; set; }
        public string State { get; set; }
        public string RegName { get; set; }
        public string RegAlt1 { get; set; }
        public byte Lvl { get; set; }
        public short Parent { get; set; }
        public string Status { get; set; }

        public Sttmas SttCodeNavigation { get; set; }
    }
}
