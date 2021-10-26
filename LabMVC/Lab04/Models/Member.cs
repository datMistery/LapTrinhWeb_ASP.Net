using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab04.Models
{
	public class Member
	{
		[Required(ErrorMessage = "Tên đăng nhập không được rỗng")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Mật khẩu không được rỗng")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Họ tên không được rỗng")]
		public string Fullname { get; set; }
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public string DatOfBirth { get; set; }
		[EmailAddress(ErrorMessage = "Email không hợp lệ")]
		public string Email { get; set; }
		[Range(1_000_000, 50_000_000, ErrorMessage = "Thu nhập từ 1 triệu đến 50 triệu")]
		public float Income { get; set; }
	}
}