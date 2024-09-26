using System.ComponentModel.DataAnnotations;

namespace MiniProject1.Models
{
	public class Lop
	{
		[Key]
		public int MaLop { get; set; }
		public string TenLop { get; set; }
		public int SiSo { get; set; }

		public virtual ICollection<SinhVien> SinhViens { get; set; }
	}

}
