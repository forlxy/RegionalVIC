using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("LGAMAS")]
    public partial class Lgamas
    {
        public Lgamas()
        {
            Cmmtbl = new HashSet<Cmmtbl>();
            Cobtbl = new HashSet<Cobtbl>();
            Critbl = new HashSet<Critbl>();
            Inctbl = new HashSet<Inctbl>();
            Lggtbl = new HashSet<Lggtbl>();
            Nbitbl = new HashSet<Nbitbl>();
            Poetbl = new HashSet<Poetbl>();
            Ppltbl = new HashSet<Ppltbl>();
            Rtrtbl = new HashSet<Rtrtbl>();
            Ueptbl = new HashSet<Ueptbl>();
        }

        [Key]
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("LGA_name")]
        [StringLength(50)]
        public string LgaName { get; set; }
        [Column("LGA_bdesc")]
        [StringLength(50)]
        public string LgaBdesc { get; set; }
        [Column("LGA_desc")]
        public string LgaDesc { get; set; }
        [Column("LGA_area", TypeName = "decimal(18, 3)")]
        public decimal LgaArea { get; set; }
        [Column("LGA_ref")]
        public string LgaRef { get; set; }
        [Column("LGA_image")]
        public string LgaImage { get; set; }
        [Column("LGA_video")]
        public string LgaVideo { get; set; }
        [Column("LGA_longitude")]
        public double? LgaLongitude { get; set; }
        [Column("LGA_latitude")]
        public double? LgaLatitude { get; set; }
        [Required]
        [Column("state")]
        [StringLength(3)]
        public string State { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey("State")]
        [InverseProperty("Lgamas")]
        public Sttmas StateNavigation { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public Lgatbl Lgatbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Cmmtbl> Cmmtbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Cobtbl> Cobtbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Critbl> Critbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Inctbl> Inctbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Lggtbl> Lggtbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Nbitbl> Nbitbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Poetbl> Poetbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Ppltbl> Ppltbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Rtrtbl> Rtrtbl { get; set; }
        [InverseProperty("LgaCodeNavigation")]
        public ICollection<Ueptbl> Ueptbl { get; set; }
    }
}
