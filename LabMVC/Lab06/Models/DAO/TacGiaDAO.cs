using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab06.Models.Entities;

namespace Lab06.Models.DAO
{
	public class TacGiaDAO
	{

		const int numberPerPage = 10;

		private QuanLyBanSachDatabaseContext databaseContext;
		public TacGiaDAO()
		{
			databaseContext = new QuanLyBanSachDatabaseContext();
		}

		public int CountTotalPage()
		{
			return databaseContext.TACGIAs.Count() / numberPerPage + 1;
		}

		private IEnumerable<TACGIA> SortByMaTG(int skip, int take, string type)
        {
			var query = (type == "asc") ?
				databaseContext.TACGIAs.OrderBy(x => x.MaTG) :
				databaseContext.TACGIAs.OrderByDescending(x => x.MaTG);
			return query.Skip(skip).Take(take).ToList();
        }

		private IEnumerable<TACGIA> SortByTenTG(int skip, int take, string type)
		{
			var query = (type == "asc") ?
				databaseContext.TACGIAs.OrderBy(x => x.TenTG) :
				databaseContext.TACGIAs.OrderByDescending(x => x.TenTG);
			return query.Skip(skip).Take(take).ToList();
		}

		private IEnumerable<TACGIA> SortByDiaChiTG(int skip, int take, string type)
		{
			var query = (type == "asc") ?
				databaseContext.TACGIAs.OrderBy(x => x.DiaChiTG) :
				databaseContext.TACGIAs.OrderByDescending(x => x.DiaChiTG);
			return query.Skip(skip).Take(take).ToList();
		}

		private IEnumerable<TACGIA> SortByDienThoaiTG(int skip, int take, string type)
		{
			var query = (type == "asc") ?
				databaseContext.TACGIAs.OrderBy(x => x.DienThoaiTG) :
				databaseContext.TACGIAs.OrderByDescending(x => x.DienThoaiTG);
			return query.Skip(skip).Take(take).ToList();
		}


		public IEnumerable<TACGIA> GetTacGia(int page, string key, string type)
		{
			if (page < 1)
            {
				page = 1;
            }

			switch (key) {
				case "TenTG":
					return SortByTenTG(numberPerPage * (page - 1), numberPerPage, type);
				case "DiaChiTG":
					return SortByDiaChiTG(numberPerPage * (page - 1), numberPerPage, type);
				case "DienThoaiTG":
					return SortByDienThoaiTG(numberPerPage * (page - 1), numberPerPage, type);
				default:
					return SortByMaTG(numberPerPage * (page - 1), numberPerPage, type);
			}
		}
    }
}