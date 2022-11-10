using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Sach")]
    public partial class Sach
    {
        public Sach()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string MaSach { get; set; }
        [Required]
        [StringLength(50)]
        public string MaTheLoaiChiTiet { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public int? SoLuong { get; set; }
        [Required]
        [StringLength(50)]
        public string TacGia { get; set; }
        [Required]
        [StringLength(50)]
        public string MoTa { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayNhap { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayXuat { get; set; }
        public int? SoLuongConLai { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaTheLoaiChiTiet))]
        [InverseProperty(nameof(TheLoaiChiTiet.Saches))]
        public virtual TheLoaiChiTiet MaTheLoaiChiTietNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaSachNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
