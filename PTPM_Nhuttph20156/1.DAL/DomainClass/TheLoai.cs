using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("TheLoai")]
    public partial class TheLoai
    {
        public TheLoai()
        {
            TheLoaiChiTiets = new HashSet<TheLoaiChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string MaTheLoai { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(TheLoaiChiTiet.MaTheLoaiNavigation))]
        public virtual ICollection<TheLoaiChiTiet> TheLoaiChiTiets { get; set; }
    }
}
