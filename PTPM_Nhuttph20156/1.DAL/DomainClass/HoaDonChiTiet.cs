using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [StringLength(50)]
        public string MaHoaDonChiTiet { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [Required]
        [StringLength(50)]
        public string MaSach { get; set; }
        [Required]
        [StringLength(50)]
        public string MaGiamGia { get; set; }
        public int? GiaGoc { get; set; }
        public int? GiaCuoi { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(MaGiamGia))]
        [InverseProperty(nameof(GiamGium.HoaDonChiTiets))]
        public virtual GiamGium MaGiamGiaNavigation { get; set; }
        [ForeignKey(nameof(MaHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon MaHoaDonNavigation { get; set; }
        [ForeignKey(nameof(MaSach))]
        [InverseProperty(nameof(Sach.HoaDonChiTiets))]
        public virtual Sach MaSachNavigation { get; set; }
    }
}
