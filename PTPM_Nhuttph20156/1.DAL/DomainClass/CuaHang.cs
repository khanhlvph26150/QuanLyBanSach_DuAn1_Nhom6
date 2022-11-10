using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("CuaHang")]
    public partial class CuaHang
    {
        public CuaHang()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [Column("MaCH")]
        [StringLength(50)]
        public string MaCh { get; set; }
        [Required]
        [Column("TenCH")]
        [StringLength(50)]
        public string TenCh { get; set; }
        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [InverseProperty(nameof(NhanVien.MaChNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
