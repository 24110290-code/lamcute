
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Data
{
    public class QLNVDBContext : DbContext
    {
        public QLNVDBContext(
            DbContextOptions<QLNVDBContext> options)
            : base(options)
        {
        }

        public DbSet<NhanVien> NhanViens { get; set; }

        public DbSet<PhongBan> PhongBans { get; set; }
    }
}
