namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTTHAMDO")]
    public partial class CTTHAMDO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Required]
        [StringLength(255)]
        public string NoiDungTraLoi { get; set; }

        public int? SoLanBinhChon { get; set; }

        public virtual THAMDO THAMDO { get; set; }
    }
}
