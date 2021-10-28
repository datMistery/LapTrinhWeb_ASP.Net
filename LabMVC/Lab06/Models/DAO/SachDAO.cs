using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Lab06.Models.Entities;
using Lab06.Models.ViewModel;

namespace Lab06.Models.DAO
{
	public class SachDAO
	{
		const int numberPerPage = 10;
		private QuanLyBanSachDatabaseContext databaseContext;

		public SachDAO()
		{
			databaseContext = new QuanLyBanSachDatabaseContext();
		}

		public int CountTotalPage(Func<SACH, bool> predicate = null)
		{
			if (predicate == null)
			{
				return databaseContext.SACHes.Count() / numberPerPage + 1;
			}

			return databaseContext.SACHes.Count(predicate) / numberPerPage + 1;
		}

		public IEnumerable<SACH> GetSachTheoNXB(int page, int MaNXB)
		{
			if (page < 1)
			{
				page = 1;
			}

			var query = databaseContext.SACHes;
			if (MaNXB <= 0)
			{
				return query
					.OrderBy(x => x.MaSach)
					.Skip(numberPerPage * (page - 1))
					.Take(numberPerPage)
					.ToList();
			}
			
			return query
				.OrderBy(x => x.MaSach)
				.Where(x => x.MaNXB == MaNXB)
				.Skip(numberPerPage * (page - 1))
				.Take(numberPerPage)
				.ToList();
		}

		public IEnumerable<SACH> GetSachTheoChuDe(int page, int MaCD)
		{
			if (page < 1)
			{
				page = 1;
			}

			var query = databaseContext.SACHes;
			if (MaCD <= 0)
			{
				return query
					.OrderBy(x => x.MaSach)
					.Skip(numberPerPage * (page - 1))
					.Take(numberPerPage)
					.ToList();
			}

			return query
				.OrderBy(x => x.MaSach)
				.Where(x => x.MaCD == MaCD)
				.Skip(numberPerPage * (page - 1))
				.Take(numberPerPage)
				.ToList();
		}

		public IEnumerable<SachViewModel> GetSachTheoDonGia(int page, decimal GiaTu, decimal GiaDen)
		{
			if (page < 1)
			{
				page = 1;
			}

			var parameters = new SqlParameter[] {
				new SqlParameter("@GiaTu", GiaTu),
				new SqlParameter("@GiaDen", GiaDen),
			};

			return databaseContext.Database
				.SqlQuery<SachViewModel>("SachTheoGia @GiaTu, @GiaDen", parameters)
				.OrderBy(x => x.DonGia)
				.Skip(numberPerPage * (page - 1))
				.Take(numberPerPage)
				.ToList();
		}
	}
}