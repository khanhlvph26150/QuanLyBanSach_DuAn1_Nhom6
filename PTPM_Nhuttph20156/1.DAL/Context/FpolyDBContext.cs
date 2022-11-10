using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<GiamGium> GiamGia { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TheLoaiChiTiet> TheLoaiChiTiets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=THUYNHU\\SQLEXPRESS;Initial Catalog=Nhom6_DuAn1_IT17304;Persist Security Info=True;User ID=chiuchiu;Password=30062003");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaCv)
                    .HasName("PK__ChucVu__27258E76172084A5");

                entity.Property(e => e.MaCv).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasKey(e => e.MaCh)
                    .HasName("PK__CuaHang__27258E00692B2264");

                entity.Property(e => e.MaCh).IsUnicode(false);
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.MaGg)
                    .HasName("PK__GiamGia__2725AE82EE0B3959");

                entity.Property(e => e.MaGg).IsUnicode(false);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B3620A109");

                entity.Property(e => e.MaHoaDon).IsUnicode(false);

                entity.Property(e => e.MaKhachHang).IsUnicode(false);

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaKhachH__5070F446");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__5165187F");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__6C2FD0CE90E30EA8");

                entity.Property(e => e.MaHoaDonChiTiet).IsUnicode(false);

                entity.Property(e => e.MaGiamGia).IsUnicode(false);

                entity.Property(e => e.MaHoaDon).IsUnicode(false);

                entity.Property(e => e.MaSach).IsUnicode(false);

                entity.HasOne(d => d.MaGiamGiaNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaGiamGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaGia__4F7CD00D");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaHoa__4D94879B");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaSac__4E88ABD4");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E55D74978C");

                entity.Property(e => e.MaKhachHang).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA479E83A77A");

                entity.Property(e => e.MaNhanVien).IsUnicode(false);

                entity.Property(e => e.MaCh).IsUnicode(false);

                entity.Property(e => e.MaChucVu).IsUnicode(false);

                entity.Property(e => e.SoDienThoai).IsUnicode(false);

                entity.HasOne(d => d.MaChNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaCh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaCH__52593CB8");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaChuc__534D60F1");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__Sach__B235742D1B3E6836");

                entity.Property(e => e.MaSach).IsUnicode(false);

                entity.Property(e => e.MaTheLoaiChiTiet).IsUnicode(false);

                entity.HasOne(d => d.MaTheLoaiChiTietNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.MaTheLoaiChiTiet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sach__MaTheLoaiC__5441852A");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__TheLoai__D73FF34A77ABC0C2");

                entity.Property(e => e.MaTheLoai).IsUnicode(false);
            });

            modelBuilder.Entity<TheLoaiChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaTheLoaiChiTiet)
                    .HasName("PK__TheLoaiC__7B2AE26BAD4A84B6");

                entity.Property(e => e.MaTheLoaiChiTiet).IsUnicode(false);

                entity.Property(e => e.MaTheLoai).IsUnicode(false);

                entity.HasOne(d => d.MaTheLoaiNavigation)
                    .WithMany(p => p.TheLoaiChiTiets)
                    .HasForeignKey(d => d.MaTheLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheLoaiCh__MaThe__5535A963");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
