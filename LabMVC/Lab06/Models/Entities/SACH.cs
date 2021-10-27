namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CTDATHANGs = new HashSet<CTDATHANG>();
            VIETSACHes = new HashSet<VIETSACH>();
        }

        [Key]
        public int MaSach { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [StringLength(50)]
        public string HinhMinhHoa { get; set; }

        public int? MaCD { get; set; }

        public int? MaNXB { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongBan { get; set; }

        public int? SoLanXem { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
