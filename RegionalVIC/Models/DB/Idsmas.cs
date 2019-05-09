using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("IDSMAS")]
    public partial class Idsmas
    {
        public Idsmas()
        {
            Nbitbl = new HashSet<Nbitbl>();
            Poetbl = new HashSet<Poetbl>();
        }

        [Key]
        [Column("ids_code")]
        public short IdsCode { get; set; }
        [Required]
        [Column("ids_name")]
        [StringLength(50)]
        public string IdsName { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [InverseProperty("IdsCodeNavigation")]
        public ICollection<Nbitbl> Nbitbl { get; set; }
        [InverseProperty("IdsCodeNavigation")]
        public ICollection<Poetbl> Poetbl { get; set; }
    }
}
