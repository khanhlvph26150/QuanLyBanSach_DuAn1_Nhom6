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
//    public class QLCuaHangService : ICuaHangService
//    {
//        private ICuaHangRepository _iCuaHangRepository;
//        public QLCuaHangService()
//        {
//            _iCuaHangRepository = new CuaHangRepository();
//        }
//        public string Add(CuaHangView dspView)
//        {
//            if (dspView == null) return "Them khong thanh cong";
//            var obj = new CuaHang()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//                DiaChi = dspView.DiaChi,
//                ThanhPho = dspView.ThanhPho,
//                QuocGia = dspView.QuocGia,
//            };
//            if (_iCuaHangRepository.AddCuaHang(obj))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(CuaHangView dspView)
//        {
//            if (dspView == null) return "Xoa khong thanh cong";
//            var obj = new CuaHang()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//                DiaChi = dspView.DiaChi,
//                ThanhPho = dspView.ThanhPho,
//                QuocGia = dspView.QuocGia,
//            };
//            if (_iCuaHangRepository.DeleteCuaHang(obj))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<CuaHangView> GetAll()
//        {
//            List<CuaHangView> list = new List<CuaHangView>();
//            list = (from n in _iCuaHangRepository.GetAllCuaHang()
//                    select new CuaHangView
//                    {
//                        Id=n.Id,
//                        Ma = n.Ma,
//                        Ten =n.Ten,
//                        DiaChi = n.DiaChi,
//                        ThanhPho = n.ThanhPho,
//                        QuocGia = n.QuocGia,
//                    }).ToList();
//            return list;
//        }

//        public Guid GetIdCuaHangFromTen(string ten)
//        {
//            throw new NotImplementedException();
//        }

//        public string Update(CuaHangView dspView)
//        {
//            if (dspView == null) return "Sua khong thanh cong";
//            var obj = new CuaHang()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//                DiaChi = dspView.DiaChi,
//                ThanhPho = dspView.ThanhPho,
//                QuocGia = dspView.QuocGia,
//            };
//            if (_iCuaHangRepository.UpdateCuaHang(obj))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
