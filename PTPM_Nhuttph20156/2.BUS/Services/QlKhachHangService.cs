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
//    public class QlKhachHangService : IKhachHangService
//    {
//        private IKhachHangRepository _iKhachHangRepository;
//        public QlKhachHangService()
//        {
//            _iKhachHangRepository = new KhachHangRepository();
//        }
//        public string Add(KhachHangView kh)
//        {
//            if (kh == null) return "Them khong thanh cong";
//            var obj = new KhachHang()
//            {
//                Id = kh.Id,
//                Ma = kh.Ma,
//                Ten = kh.Ten,
//                //TenDem = kh.TenDem,
//                //Ho = kh.Ho,
//                //NgaySinh = kh.NgaySinh,
//                //Sdt = kh.Sdt,
//                DiaChi = kh.DiaChi,
//                ThanhPho = kh.ThanhPho,
//                QuocGia = kh.QuocGia,
//                MatKhau = kh.MatKhau,
//            };
//            if (_iKhachHangRepository.AddKhachHang(obj))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(KhachHangView kh)
//        {
//            if (kh == null) return "Xoa khong thanh cong";
//            var obj = new KhachHang()
//            {
//                Id = kh.Id,
//                Ma = kh.Ma,
//                Ten = kh.Ten,
//                //TenDem = kh.TenDem,
//                //Ho = kh.Ho,
//                //NgaySinh = kh.NgaySinh,
//                //Sdt = kh.Sdt,
//                DiaChi = kh.DiaChi,
//                ThanhPho = kh.ThanhPho,
//                QuocGia = kh.QuocGia,
//                MatKhau = kh.MatKhau,
//            };
//            if (_iKhachHangRepository.DeleteKhachHang(obj))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<KhachHangView> GetAll()
//        {
//            List<KhachHangView> list = new List<KhachHangView>();
//            list = (from a in _iKhachHangRepository.GetAll()
//                    select new KhachHangView
//                    {
//                        Id=a.Id,
//                        Ma=a.Ma,
//                        Ten=a.Ten,
//                        HoVaTen = string.Concat(a.TenDem + " " + a.Ten + " " + a.Ho),
//                        //TenDem = a.TenDem,
//                        //Ho = a.Ho,
//                        //NgaySinh =a.NgaySinh,
//                        //Sdt =a.Sdt,
//                        DiaChi = a.DiaChi,
//                        ThanhPho = a.ThanhPho,
//                        QuocGia = a.QuocGia,
//                        MatKhau = a.MatKhau,
//                    }).ToList();
//            return list;
//        }

//        public string Update(KhachHangView kh)
//        {
//            if (kh == null) return "Sua khong thanh cong";
//            var obj = new KhachHang()
//            {
//                Id = kh.Id,
//                Ma = kh.Ma,
//                Ten = kh.Ten,
//                //TenDem = kh.TenDem,
//                //Ho = kh.Ho,
//                //NgaySinh = kh.NgaySinh,
//                //Sdt = kh.Sdt,
//                DiaChi = kh.DiaChi,
//                ThanhPho = kh.ThanhPho,
//                QuocGia = kh.QuocGia,
//                MatKhau = kh.MatKhau,
//            };
//            if (_iKhachHangRepository.UpdateKhachHang(obj))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
