﻿using System;
using System.Collections.Generic;

namespace RegionalVIC.Models.DB
{
    public partial class Lgamas
    {
        public Lgamas()
        {
            Critbl = new HashSet<Critbl>();
        }

        public string LgaCode { get; set; }
        public string LgaName { get; set; }
        public string LgaBdesc { get; set; }
        public string LgaDesc { get; set; }
        public decimal LgaArea { get; set; }
        public string State { get; set; }
        public string Status { get; set; }

        public ICollection<Critbl> Critbl { get; set; }
    }
}