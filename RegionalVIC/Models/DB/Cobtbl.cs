using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("COBTBL")]
    public partial class Cobtbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("cob")]
        public short Cob { get; set; }
        [Column("rank")]
        public short Rank { get; set; }
        [Column("ppl")]
        public int Ppl { get; set; }
        [Column("percnt", TypeName = "decimal(3, 1)")]
        public decimal Percnt { get; set; }
        [Column("ttl_ppl")]
        public int TtlPpl { get; set; }

        [ForeignKey("Cob")]
        [InverseProperty("Cobtbl")]
        public Cobmas CobNavigation { get; set; }
        [ForeignKey("LgaCode")]
        [InverseProperty("Cobtbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
