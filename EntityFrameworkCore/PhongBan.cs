
using System.ComponentModel.DataAnnotations;

namespace QuanLyNhanVien.Models
{
    public class PhongBan
    {
        [Key]
        public int PhongBanId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenPhongBan { get; set; } = string.Empty;

        public ICollection<NhanVien> NhanViens { get; set; }
            = new List<NhanVien>();
    }
}
