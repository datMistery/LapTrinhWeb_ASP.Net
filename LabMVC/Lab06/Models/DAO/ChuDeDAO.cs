using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab06.Models.Entities;

namespace Lab06.Models.DAO
{
	public class ChuDeDAO
	{
		private QuanLyBanSachDatabaseContext databaseContext;

		public ChuDeDAO()
		{
			databaseContext = new QuanLyBanSachDatabaseContext();
		}

		public IEnumerable<CHUDE> GetChuDe()
		{
			return databaseContext.CHUDEs.ToList();
		}
	}
}