using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [Required]
        [StringLength(50)]
        public string MaKhachHang { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayTaoDon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NguoiTaoDon { get; set; }
        public int? Gia { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(MaKhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang MaKhachHangNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien MaNhanVienNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
