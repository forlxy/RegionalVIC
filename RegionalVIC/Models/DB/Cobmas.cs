using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("COBMAS")]
    public partial class Cobmas
    {
        public Cobmas()
        {
            Cmmtbl = new HashSet<Cmmtbl>();
            Cobtbl = new HashSet<Cobtbl>();
        }

        [Key]
        [Column("seq")]
        public short Seq { get; set; }
        [Required]
        [Column("cob")]
        [StringLength(50)]
        public string Cob { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [InverseProperty("CobCodeNavigation")]
        public ICollection<Cmmtbl> Cmmtbl { get; set; }
        [InverseProperty("CobNavigation")]
        public ICollection<Cobtbl> Cobtbl { get; set; }
    }
}
