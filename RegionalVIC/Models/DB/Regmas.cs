using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("REGMAS")]
    public partial class Regmas
    {
        [Key]
        [Column("seq")]
        public short Seq { get; set; }
        [Required]
        [Column("state")]
        [StringLength(3)]
        public string State { get; set; }
        [Column("reg_name")]
        [StringLength(50)]
        public string RegName { get; set; }
        [Column("reg_alt_1")]
        [StringLength(50)]
        public string RegAlt1 { get; set; }
        [Column("lvl")]
        public byte Lvl { get; set; }
        [Column("parent")]
        public short Parent { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey("State")]
        [InverseProperty("Regmas")]
        public Sttmas StateNavigation { get; set; }
    }
}
