//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using _1.DAL.Repositories;
//using _2.BUS.IServices;
//using _2.BUS.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2.BUS.Services
//{
//    public class QlNhanVienService : INhanVienService
//    {
//        private INhanVienRepository _iNvRepository;
//        private ICuaHangRepository _cuaHangRepository;
//        private IChucVuRepository _chucVuRepository;
//        public QlNhanVienService()
//        {
//            _iNvRepository = new NhanVienRepository();
//            _cuaHangRepository = new CuaHangRepository();
//            _chucVuRepository = new ChucVuRepository();
//        }
//        public string Add(NhanVienView nvv)
//        {
//            if (nvv == null)
//            {
//                return "Them khong thanh cong";
//            }
//            var temp = new NhanVien()
//            {
//                Id = nvv.Id,
//                Ma = nvv.Ma,
//                Ten = nvv.Ten,
//                //TenDem = nvv.TenDem,
//                //Ho = nvv.Ho,
//                //GioiTinh = nvv.GioiTinh,
//                //NgaySinh = nvv.NgaySinh,
//                //DiaChi = nvv.DiaChi,
//                Sdt = nvv.Sdt,
//                //MatKhau = nvv.MatKhau,
//                //IdCh = nvv.IdCh,
//                //IdCv = nvv.IdCv,
//            };
//            if (_iNvRepository.AddNhanVien(temp))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(NhanVienView nvv)
//        {
//            if (nvv == null) return "Xóa không thành công";

//            var temp = new NhanVien()
//            {
//                Id = nvv.Id,
//                Ma = nvv.Ma,
//                Ten = nvv.Ten,
//                //TenDem = nvv.TenDem,
//                //Ho = nvv.Ho,
//                //GioiTinh = nvv.GioiTinh,
//                //NgaySinh = nvv.NgaySinh,
//                //DiaChi = nvv.DiaChi,
//                Sdt = nvv.Sdt,
//                //MatKhau = nvv.MatKhau,
//                //IdCh = nvv.IdCh,
//                //IdCv = nvv.IdCv,
//            };
//            if (_iNvRepository.DeleteNhanVien(temp))
//            {
//                GetAll();
//                return "Xóa thành công";
//            };
//            return "Xóa không thành công";
//        }

//        public List<NhanVienView> GetAll()
//        {
//            List<NhanVienView> nvView = new List<NhanVienView>();
//            nvView = (from a in _iNvRepository.GetAll()
//                      //join b in _cuaHangRepository.GetAllCuaHang() on a.IdCh equals b.Id
//                      //join c in _chucVuRepository.GetAllChucVu() on a.IdCv equals c.Id
//                      select new NhanVienView
//                      {
//                          Id = a.Id,
//                          Ma = a.Ma,
//                          Ten = a.Ten,
//                          Sdt = a.Sdt,
//                          HovaTen = string.Concat(a.TenDem + " " + a.Ten + " " + a.Ho)                         
//                          //MatKhau = a.MatKhau,

//                          //MatKhau = a.MatKhau,
//                          //IdCh = b.Id,
//                          //IdCv = c.Id,
//                      }).ToList();
//            return nvView;
//        }

//        public string Update(NhanVienView nvv)
//        {
//            if (nvv == null) return "Sửa không thành công";
//            var temp = new NhanVien()
//            {
//                Id = nvv.Id,
//                Ma = nvv.Ma,
//                Ten = nvv.Ten,
//                //TenDem = nvv.TenDem,
//                //Ho = nvv.Ho,
//                //GioiTinh = nvv.GioiTinh,
//                //NgaySinh = nvv.NgaySinh,
//                //DiaChi = nvv.DiaChi,
//                Sdt = nvv.Sdt,
//                //MatKhau = nvv.MatKhau,
//                //IdCh = nvv.IdCh,
//                //IdCv = nvv.IdCv,
//            };
//            if (_iNvRepository.UpdateNhanVien(temp))
//            {
//                GetAll();
//                return "Sửa thành công";
//            };
//            return "Sửa không thành công";
//        }
//    }
//}
