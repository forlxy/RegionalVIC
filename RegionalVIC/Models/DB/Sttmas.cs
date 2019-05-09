using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("STTMAS")]
    public partial class Sttmas
    {
        public Sttmas()
        {
            Lgamas = new HashSet<Lgamas>();
            Regmas = new HashSet<Regmas>();
            Sbbmas = new HashSet<Sbbmas>();
        }

        [Key]
        [Column("state_code")]
        [StringLength(3)]
        public string StateCode { get; set; }
        [Column("area_code")]
        [StringLength(2)]
        public string AreaCode { get; set; }
        [Column("state_name")]
        [StringLength(50)]
        public string StateName { get; set; }
        [Column("capital")]
        [StringLength(50)]
        public string Capital { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [InverseProperty("StateNavigation")]
        public ICollection<Lgamas> Lgamas { get; set; }
        [InverseProperty("StateNavigation")]
        public ICollection<Regmas> Regmas { get; set; }
        [InverseProperty("StateNavigation")]
        public ICollection<Sbbmas> Sbbmas { get; set; }
    }
}
