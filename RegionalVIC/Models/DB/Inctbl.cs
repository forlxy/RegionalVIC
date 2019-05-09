using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("INCTBL")]
    public partial class Inctbl
    {
        [Column("yr")]
        public short Yr { get; set; }
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("me_ttl_emp_inc", TypeName = "numeric(18, 2)")]
        public decimal? MeTtlEmpInc { get; set; }
        [Column("me_ttl_inv_inc", TypeName = "numeric(18, 2)")]
        public decimal? MeTtlInvInc { get; set; }
        [Column("me_ttl_inc", TypeName = "numeric(18, 2)")]
        public decimal? MeTtlInc { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Inctbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
