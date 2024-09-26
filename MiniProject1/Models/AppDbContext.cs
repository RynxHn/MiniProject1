using Microsoft.EntityFrameworkCore;

namespace MiniProject1.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Lop> Lops { get; set; }
		public DbSet<SinhVien> SinhViens { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Lop>().ToTable("Lop");
			modelBuilder.Entity<SinhVien>().ToTable("SinhVien");

			modelBuilder.Entity<SinhVien>()
				.HasOne(s => s.Lop)
				.WithMany(l => l.SinhViens)
				.HasForeignKey(s => s.MaLop);
		}
	}
}
