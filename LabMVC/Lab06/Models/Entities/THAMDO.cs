namespace Lab06.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMDO")]
    public partial class THAMDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THAMDO()
        {
            CTTHAMDOes = new HashSet<CTTHAMDO>();
        }

        [Key]
        public int MaCH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDang { get; set; }

        [Required]
        [StringLength(255)]
        public string NoiDungThamDo { get; set; }

        public int? TongSoBinhChon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTHAMDO> CTTHAMDOes { get; set; }
    }
}
