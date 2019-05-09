using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("CRITBL")]
    public partial class Critbl
    {
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("yr_end")]
        public short YrEnd { get; set; }
        [Column("pol_region")]
        [StringLength(50)]
        public string PolRegion { get; set; }
        [Column("incd_rcd")]
        public int IncdRcd { get; set; }
        [Column("rate_per_ppl", TypeName = "decimal(18, 6)")]
        public decimal RatePerPpl { get; set; }
        [Column("rate", TypeName = "decimal(18, 9)")]
        public decimal Rate { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Critbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
