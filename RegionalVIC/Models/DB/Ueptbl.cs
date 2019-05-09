using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("UEPTBL")]
    public partial class Ueptbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("labour_force")]
        public int LabourForce { get; set; }
        [Column("unemp_no")]
        public int UnempNo { get; set; }
        [Column("unemp_rate", TypeName = "decimal(3, 1)")]
        public decimal UnempRate { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Ueptbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
