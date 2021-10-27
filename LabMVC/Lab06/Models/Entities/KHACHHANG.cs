namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DONDATHANGs = new HashSet<DONDATHANG>();
        }

        [Key]
        public int MaKH { get; set; }

        [StringLength(50)]
        public string HoTenKH { get; set; }

        [StringLength(50)]
        public string DiaChiKH { get; set; }

        [StringLength(10)]
        public string DienThoaiKH { get; set; }

        [StringLength(15)]
        public string TenDN { get; set; }

        [StringLength(15)]
        public string MatKhau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? DaDuyet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}
