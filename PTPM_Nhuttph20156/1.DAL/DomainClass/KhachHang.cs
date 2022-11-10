using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string MaKhachHang { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }
        [Required]
        [StringLength(50)]
        public string Sdt { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(HoaDon.MaKhachHangNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
