using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private FpolyDBContext _dbContext;
        List<Sach> _lstSach;

        public SanPhamRepository()
        {
            _dbContext = new FpolyDBContext();
            _lstSach = new List<Sach>();
        }

        public bool AddSach(Sach sach)
        {
            if (sach == null) return false;
            _dbContext.Saches.Add(sach);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSach(Sach sach)
        {
            if (sach == null) return false;
            var tempobj = _dbContext.Saches.FirstOrDefault(c => c.MaSach == sach.MaSach);
            _dbContext.Saches.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<Sach> GetAll()
        {
            _lstSach = _dbContext.Saches.ToList();
            return _lstSach;
        }

        public Sach GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSach(Sach sach)
        {
            if (sach == null) return false;
            //obj.Id = Guid.NewGuid();// tu dong zen khoa chinh
            var tempobj = _dbContext.Saches.FirstOrDefault(c => c.MaSach == sach.MaSach);
            tempobj.MaTheLoaiChiTiet = sach.MaTheLoaiChiTiet;
            tempobj.NgayXuatBan = sach.NgayXuatBan;
            tempobj.SoTrang = sach.SoTrang;
            tempobj.SoLuong = sach.SoLuong;
            tempobj.MoTa = sach.MoTa;
            tempobj.TacGia = sach.TacGia;
            tempobj.NgayNhap = sach.NgayNhap;
            tempobj.NgayXuat = sach.NgayXuat;
            tempobj.SoLuongConLai = sach.SoLuongConLai;
            tempobj.TrangThai = sach.TrangThai;
            _dbContext.Saches.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
       
    }
}
