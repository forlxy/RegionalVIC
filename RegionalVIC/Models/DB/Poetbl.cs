using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("POETBL")]
    public partial class Poetbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("ids_code")]
        public short IdsCode { get; set; }
        [Column("proportion", TypeName = "decimal(3, 1)")]
        public decimal Proportion { get; set; }

        [ForeignKey("IdsCode")]
        [InverseProperty("Poetbl")]
        public Idsmas IdsCodeNavigation { get; set; }
        [ForeignKey("LgaCode")]
        [InverseProperty("Poetbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
