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
    public class KhachHangRepository : IKhachHangRepository
    {
        private FpolyDBContext _dbContext;
        List<KhachHang> _lstKH;
        public KhachHangRepository()
        {
            _dbContext = new FpolyDBContext();
            _lstKH = new List<KhachHang>();

        }

        public bool AddKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            _dbContext.KhachHangs.Add(kh);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(p => p.MaKhachHang == kh.MaKhachHang);
            _dbContext.KhachHangs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            _lstKH = _dbContext.KhachHangs.ToList();
            return _lstKH;
        }

        public KhachHang GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }


        public bool UpdateKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(p => p.MaKhachHang == kh.MaKhachHang);
            //temp.Ma = kh.Ma;
            temp.HoTen = kh.HoTen;
            temp.GioiTinh = kh.GioiTinh;
            temp.Tuoi = kh.Tuoi;
            temp.Sdt = kh.Sdt;
            temp.Email = kh.Email;
            temp.DiaChi = kh.DiaChi;
            temp.TrangThai = kh.TrangThai;
            _dbContext.KhachHangs.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
