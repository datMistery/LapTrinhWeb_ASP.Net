namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TACGIA")]
    public partial class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            VIETSACHes = new HashSet<VIETSACH>();
        }

        [Key]
        public int MaTG { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTG { get; set; }

        [StringLength(100)]
        public string DiaChiTG { get; set; }

        [StringLength(15)]
        public string DienThoaiTG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
