namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANGCAO")]
    public partial class QUANGCAO
    {
        [Key]
        public int STT { get; set; }

        [Required]
        [StringLength(200)]
        public string TenCongTy { get; set; }

        [StringLength(20)]
        public string HinhMinhHoa { get; set; }

        [StringLength(100)]
        public string Href { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayHetHan { get; set; }
    }
}
