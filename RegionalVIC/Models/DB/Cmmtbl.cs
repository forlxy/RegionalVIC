using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("CMMTBL")]
    public partial class Cmmtbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("cob_code")]
        public short CobCode { get; set; }
        [Column("rank")]
        public byte Rank { get; set; }
        [Column("suburbs")]
        public string Suburbs { get; set; }
        [Column("ppl")]
        public int Ppl { get; set; }
        [Column("percnt", TypeName = "decimal(3, 1)")]
        public decimal Percnt { get; set; }
        [Column("total_ppl")]
        public int TotalPpl { get; set; }

        [ForeignKey("CobCode")]
        [InverseProperty("Cmmtbl")]
        public Cobmas CobCodeNavigation { get; set; }
        [ForeignKey("LgaCode")]
        [InverseProperty("Cmmtbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
