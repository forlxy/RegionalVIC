using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("RTRTBL")]
    public partial class Rtrtbl
    {
        [Key]
        [Column("seq")]
        public long Seq { get; set; }
        [Column("yr")]
        public short Yr { get; set; }
        [Required]
        [Column("mth")]
        [StringLength(3)]
        public string Mth { get; set; }
        [Column("quarter")]
        public byte Quarter { get; set; }
        [Column("region")]
        [StringLength(50)]
        public string Region { get; set; }
        [Required]
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("typ")]
        [StringLength(20)]
        public string Typ { get; set; }
        [Column("no_of_bedrm")]
        public byte? NoOfBedrm { get; set; }
        [Column("count")]
        public int? Count { get; set; }
        [Column("median")]
        public int? Median { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Rtrtbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
