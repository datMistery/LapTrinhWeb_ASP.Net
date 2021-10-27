namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDATHANG")]
    public partial class CTDATHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        public int? SoLuong { get; set; }

        public decimal? DonGia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }

        public virtual DONDATHANG DONDATHANG { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
