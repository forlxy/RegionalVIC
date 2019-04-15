using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Sttmas
    {
        public Sttmas()
        {
            Lgamas = new HashSet<Lgamas>();
            Regmas = new HashSet<Regmas>();
            Sbbmas = new HashSet<Sbbmas>();
        }

        public string StateCode { get; set; }
        public string AreaCode { get; set; }
        public string StateName { get; set; }
        public string Capital { get; set; }
        public string Status { get; set; }

        public ICollection<Lgamas> Lgamas { get; set; }
        public ICollection<Regmas> Regmas { get; set; }
        public ICollection<Sbbmas> Sbbmas { get; set; }
    }
}
