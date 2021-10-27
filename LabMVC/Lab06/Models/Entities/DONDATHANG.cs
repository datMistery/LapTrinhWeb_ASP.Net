namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            CTDATHANGs = new HashSet<CTDATHANG>();
        }

        [Key]
        public int SoDH { get; set; }

        public int? MaKH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDH { get; set; }

        [Column(TypeName = "money")]
        public decimal? TriGia { get; set; }

        public bool? DaGiao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayGiaoHang { get; set; }

        [StringLength(50)]
        public string TenNguoiNhan { get; set; }

        [StringLength(50)]
        public string DiaChiNhan { get; set; }

        [StringLength(15)]
        public string DienThoaiNhan { get; set; }

        public bool? HTThanhToan { get; set; }

        public bool? HTGiaoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
