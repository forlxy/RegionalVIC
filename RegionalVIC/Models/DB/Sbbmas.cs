using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Sbbmas
    {
        public short Seq { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }
    }
}
