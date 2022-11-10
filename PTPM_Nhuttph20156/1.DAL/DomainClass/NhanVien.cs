using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [Required]
        [StringLength(50)]
        public string MaChucVu { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        [Required]
        [StringLength(50)]
        public string QueQuan { get; set; }
        public bool GioiTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public int TrangThai { get; set; }
        [Required]
        [Column("MaCH")]
        [StringLength(50)]
        public string MaCh { get; set; }

        [ForeignKey(nameof(MaCh))]
        [InverseProperty(nameof(CuaHang.NhanViens))]
        public virtual CuaHang MaChNavigation { get; set; }
        [ForeignKey(nameof(MaChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu MaChucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
