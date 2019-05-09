using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("LGGTBL")]
    public partial class Lggtbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("lang_code")]
        public short LangCode { get; set; }
        [Column("rank")]
        public byte Rank { get; set; }
        [Column("ppl")]
        public int Ppl { get; set; }
        [Column("percnt", TypeName = "decimal(3, 1)")]
        public decimal Percnt { get; set; }
        [Column("ttl_ppl")]
        public int TtlPpl { get; set; }

        [ForeignKey("LangCode")]
        [InverseProperty("Lggtbl")]
        public Lggmas LangCodeNavigation { get; set; }
        [ForeignKey("LgaCode")]
        [InverseProperty("Lggtbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
