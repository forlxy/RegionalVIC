﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("PPLTBL")]
    public partial class Ppltbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("popul")]
        public int Popul { get; set; }
        [Column("density", TypeName = "decimal(18, 4)")]
        public decimal Density { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Ppltbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
