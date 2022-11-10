using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        private FpolyDBContext _dBContext;
        List<NhanVien> _NhanVienList;
        public NhanVienRepository()
        {
            _dBContext = new FpolyDBContext();
            _NhanVienList = new List<NhanVien>();
        }

        public bool AddNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            _dBContext.Add(nv);
            _dBContext.SaveChanges();
            return true;
        }


        public bool DeleteNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            var tempobj = _dBContext.NhanViens.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            _NhanVienList = _dBContext.NhanViens.ToList();
            return _NhanVienList;
        }

        public NhanVien GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            var obj = _dBContext.NhanViens.FirstOrDefault(c => c.MaNhanVien == nv.MaNhanVien);
            obj.MaChucVu = nv.MaChucVu;
            obj.MaCh = nv.MaCh;
            obj.HoTen = nv.HoTen;
            obj.Tuoi = nv.Tuoi;
            obj.QueQuan = nv.QueQuan;
            obj.GioiTinh = nv.GioiTinh;
            obj.SoDienThoai = nv.SoDienThoai;
            obj.Email = nv.Email;
            obj.TrangThai = nv.TrangThai;
          
            _dBContext.Update(obj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
