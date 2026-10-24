
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhanVien.Models
{
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; }

        [Required]
        [MaxLength(100)]
        public string HoTen { get; set; } = string.Empty;

        public DateTime NgaySinh { get; set; }

        [Required]
        [MaxLength(100)]
        public string ChucVu { get; set; } = string.Empty;

        public decimal Luong { get; set; }

        public int PhongBanId { get; set; }

        public PhongBan PhongBan { get; set; } = null!;
    }
}
