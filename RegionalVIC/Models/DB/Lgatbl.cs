using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Lgatbl
    {
        public string LgaCode { get; set; }
        public string LgaName { get; set; }
        public string NameRent { get; set; }
        public string NameCrime { get; set; }
        public string Region { get; set; }
        public string Status { get; set; }

        public Lgamas LgaCodeNavigation { get; set; }
    }
}
