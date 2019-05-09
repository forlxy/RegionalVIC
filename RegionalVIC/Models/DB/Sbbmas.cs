using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("SBBMAS")]
    public partial class Sbbmas
    {
        [Key]
        [Column("seq")]
        public short Seq { get; set; }
        [Required]
        [Column("post_code")]
        [StringLength(4)]
        public string PostCode { get; set; }
        [Required]
        [Column("state")]
        [StringLength(3)]
        public string State { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("area")]
        [StringLength(50)]
        public string Area { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey("State")]
        [InverseProperty("Sbbmas")]
        public Sttmas StateNavigation { get; set; }
    }
}
