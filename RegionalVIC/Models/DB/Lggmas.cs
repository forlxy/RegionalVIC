using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("LGGMAS")]
    public partial class Lggmas
    {
        public Lggmas()
        {
            Lggtbl = new HashSet<Lggtbl>();
        }

        [Key]
        [Column("seq")]
        public short Seq { get; set; }
        [Required]
        [Column("language")]
        [StringLength(50)]
        public string Language { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [InverseProperty("LangCodeNavigation")]
        public ICollection<Lggtbl> Lggtbl { get; set; }
    }
}
