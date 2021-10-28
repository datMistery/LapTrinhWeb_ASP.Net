using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab06.Models.Entities;

namespace Lab06.Models.DAO
{
	public class NhaXuatBanDAO
	{
		const int numberPerPage = 10;
		private QuanLyBanSachDatabaseContext databaseContext;

		public NhaXuatBanDAO()
		{
			databaseContext = new QuanLyBanSachDatabaseContext();
		}

		public int CountTotalPage()
		{
			return databaseContext.NHAXUATBANs.Count() / numberPerPage + 1;
		}

		public IEnumerable<NHAXUATBAN> GetNHAXUATBAN(int page)
		{
			if (page < 1)
			{
				page = 1;
			}

			return databaseContext.NHAXUATBANs
				.OrderBy(x => x.MaNXB)
				.Skip(numberPerPage * (page - 1))
				.Take(numberPerPage)
				.ToList();
		}
	}
}