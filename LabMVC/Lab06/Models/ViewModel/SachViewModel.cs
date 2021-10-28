using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab06.Models.Entities;

namespace Lab06.Models.ViewModel
{
	public class SachViewModel
	{
		public int MaSach { get; set; }

		public string TenSach { get; set; }
	   
		public decimal? DonGia { get; set; }

		public string MoTa { get; set; }

		public int? MaCD { get; set; }

		public int? MaNXB { get; set; }

		public DateTime? NgayCapNhat { get; set; }

		public string TenChuDe { get; set; }
		public string TenNXB { get; set; }
	}
}