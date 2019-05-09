using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("NBITBL")]
    public partial class Nbitbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("ids_code")]
        public short IdsCode { get; set; }
        [Column("no_of_bsn")]
        public int NoOfBsn { get; set; }

        [ForeignKey("IdsCode")]
        [InverseProperty("Nbitbl")]
        public Idsmas IdsCodeNavigation { get; set; }
        [ForeignKey("LgaCode")]
        [InverseProperty("Nbitbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
