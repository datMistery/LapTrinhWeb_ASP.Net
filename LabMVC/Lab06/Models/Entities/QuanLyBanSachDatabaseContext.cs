using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab06.Models.Entities
{
	public partial class QuanLyBanSachDatabaseContext : DbContext
	{
		public QuanLyBanSachDatabaseContext()
			: base("name=QuanLyBanSachDatabaseContext")
		{
		}

		public virtual DbSet<ADMIN> ADMINs { get; set; }
		public virtual DbSet<CHUDE> CHUDEs { get; set; }
		public virtual DbSet<CTDATHANG> CTDATHANGs { get; set; }
		public virtual DbSet<CTTHAMDO> CTTHAMDOes { get; set; }
		public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
		public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
		public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
		public virtual DbSet<QUANGCAO> QUANGCAOs { get; set; }
		public virtual DbSet<SACH> SACHes { get; set; }
		public virtual DbSet<TACGIA> TACGIAs { get; set; }
		public virtual DbSet<THAMDO> THAMDOes { get; set; }
		public virtual DbSet<VIETSACH> VIETSACHes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ADMIN>()
				.Property(e => e.DienThoaiAdmin)
				.IsUnicode(false);

			modelBuilder.Entity<ADMIN>()
				.Property(e => e.TenDNAdmin)
				.IsUnicode(false);

			modelBuilder.Entity<ADMIN>()
				.Property(e => e.MatKhauAdmin)
				.IsUnicode(false);

			modelBuilder.Entity<ADMIN>()
				.Property(e => e.EmailAdmin)
				.IsUnicode(false);

			modelBuilder.Entity<CTDATHANG>()
				.Property(e => e.DonGia)
				.HasPrecision(9, 2);

			modelBuilder.Entity<CTDATHANG>()
				.Property(e => e.ThanhTien)
				.HasPrecision(20, 2);

			modelBuilder.Entity<DONDATHANG>()
				.Property(e => e.TriGia)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DONDATHANG>()
				.Property(e => e.TenNguoiNhan)
				.IsUnicode(false);

			modelBuilder.Entity<DONDATHANG>()
				.Property(e => e.DienThoaiNhan)
				.IsUnicode(false);

			modelBuilder.Entity<DONDATHANG>()
				.HasMany(e => e.CTDATHANGs)
				.WithRequired(e => e.DONDATHANG)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<KHACHHANG>()
				.Property(e => e.DienThoaiKH)
				.IsUnicode(false);

			modelBuilder.Entity<KHACHHANG>()
				.Property(e => e.TenDN)
				.IsUnicode(false);

			modelBuilder.Entity<KHACHHANG>()
				.Property(e => e.MatKhau)
				.IsUnicode(false);

			modelBuilder.Entity<KHACHHANG>()
				.Property(e => e.Email)
				.IsUnicode(false);

			modelBuilder.Entity<QUANGCAO>()
				.Property(e => e.HinhMinhHoa)
				.IsUnicode(false);

			modelBuilder.Entity<QUANGCAO>()
				.Property(e => e.Href)
				.IsUnicode(false);

			modelBuilder.Entity<SACH>()
				.Property(e => e.DonGia)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SACH>()
				.Property(e => e.HinhMinhHoa)
				.IsUnicode(false);

			modelBuilder.Entity<SACH>()
				.HasMany(e => e.CTDATHANGs)
				.WithRequired(e => e.SACH)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SACH>()
				.HasMany(e => e.VIETSACHes)
				.WithRequired(e => e.SACH)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TACGIA>()
				.Property(e => e.DienThoaiTG)
				.IsUnicode(false);

			modelBuilder.Entity<TACGIA>()
				.HasMany(e => e.VIETSACHes)
				.WithRequired(e => e.TACGIA)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<THAMDO>()
				.HasMany(e => e.CTTHAMDOes)
				.WithRequired(e => e.THAMDO)
				.WillCascadeOnDelete(false);
		}
	}
}
