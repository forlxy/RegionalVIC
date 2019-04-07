using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Rtrtbl
    {
        public long Seq { get; set; }
        public short Yr { get; set; }
        public string Mth { get; set; }
        public byte Quarter { get; set; }
        public string Region { get; set; }
        public string LgaCode { get; set; }
        public string Typ { get; set; }
        public byte? NoOfBedrm { get; set; }
        public int? Count { get; set; }
        public int? Median { get; set; }
    }
}
