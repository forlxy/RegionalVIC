using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegionalVIC.Models.DB
{
    [Table("LGATBL")]
    public partial class Lgatbl
    {
        [Key]
        [Column("LGA_code")]
        [StringLength(5)]
        public string LgaCode { get; set; }
        [Column("LGA_name")]
        [StringLength(50)]
        public string LgaName { get; set; }
        [Column("name_rent")]
        [StringLength(50)]
        public string NameRent { get; set; }
        [Column("name_crime")]
        [StringLength(50)]
        public string NameCrime { get; set; }
        [Column("region")]
        [StringLength(50)]
        public string Region { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey("LgaCode")]
        [InverseProperty("Lgatbl")]
        public Lgamas LgaCodeNavigation { get; set; }
    }
}
