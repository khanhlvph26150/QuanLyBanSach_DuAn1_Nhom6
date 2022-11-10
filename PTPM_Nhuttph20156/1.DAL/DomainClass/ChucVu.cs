﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [Column("MaCV")]
        [StringLength(50)]
        public string MaCv { get; set; }
        [Required]
        [Column("TenCV")]
        [StringLength(50)]
        public string TenCv { get; set; }

        [InverseProperty(nameof(NhanVien.MaChucVuNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
