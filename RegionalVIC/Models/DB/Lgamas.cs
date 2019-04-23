using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Lgamas
    {
        public Lgamas()
        {
            Critbl = new HashSet<Critbl>();
            Lgatbl = new HashSet<Lgatbl>();
            Ppltbl = new HashSet<Ppltbl>();
            Rtrtbl = new HashSet<Rtrtbl>();
            Cobtbl = new HashSet<Cobtbl>();
            Cmmtbl = new HashSet<Cmmtbl>();
            Lggtbl = new HashSet<Lggtbl>();
        }

        public string LgaCode { get; set; }
        public string LgaName { get; set; }
        public string LgaBdesc { get; set; }
        public string LgaDesc { get; set; }
        public decimal LgaArea { get; set; }
        public string LgaImage { get; set; }
        public string LgaVideo { get; set; }
        public string State { get; set; }
        public string Status { get; set; }

        public Sttmas SttCodeNavigation { get; set; }

        public ICollection<Critbl> Critbl { get; set; }
        public ICollection<Lgatbl> Lgatbl { get; set; }
        public ICollection<Ppltbl> Ppltbl { get; set; }
        public ICollection<Rtrtbl> Rtrtbl { get; set; }
        public ICollection<Cobtbl> Cobtbl { get; set; }
        public ICollection<Cmmtbl> Cmmtbl { get; set; }
        public ICollection<Lggtbl> Lggtbl { get; set; }
    }
}
