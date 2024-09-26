using System.ComponentModel.DataAnnotations;

namespace MiniProject1.Models
{
	public class SinhVien
	{
		[Key]
		public int MaSinhVien { get; set; }
		public string HoTen { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string QueQuan { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public string TaiKhoan { get; set; }
		public string MatKhau { get; set; }
		public string AnhDaiDien { get; set; }
		public string GhiChu { get; set; }
		public int MaLop { get; set; }

		public virtual Lop Lop { get; set; }
	}

}
