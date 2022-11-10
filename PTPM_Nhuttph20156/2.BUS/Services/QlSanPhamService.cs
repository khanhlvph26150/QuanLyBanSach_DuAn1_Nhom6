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
//    public class QlSanPhamService : ISanPhamService
//    {
//        private ISanPhamRepository _iPhamRepository;
//        public QlSanPhamService()
//        {
//            _iPhamRepository = new SanPhamRepository();
//        }

//        public string Add(SanPhamView sanPhamView)
//        {
//            if (sanPhamView == null) return "Them khong thanh cong";
//            var obj = new SanPham()
//            {
//                Id = sanPhamView.Id,
//                Ma = sanPhamView.Ma,
//                 Ten = sanPhamView.Ten,
//            };
//            if (_iPhamRepository.AddSanPham(obj))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(SanPhamView sanPhamView)
//        {
//            if (sanPhamView == null) return "Xoa khong thanh cong";
//            var obj = new SanPham()
//            {
//                Id = sanPhamView.Id,
//                Ma = sanPhamView.Ma,
//                Ten = sanPhamView.Ten,
//            };
//            if (_iPhamRepository.DeleteSanPham(obj))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<SanPhamView> GetAll()
//        {
//            List<SanPhamView> list = new List<SanPhamView>();
//            list = (from n in _iPhamRepository.GetAll()
//                    select new SanPhamView
//                    {
//                        Id=n.Id,
//                        Ma=n.Ma,
//                        Ten=n.Ten,
//                    }).ToList();
//            return list;
//        }

//        public string Update(SanPhamView sanPhamView)
//        {
//            if (sanPhamView == null) return "Sua khong thanh cong";
//            var obj = new SanPham()
//            {
//                Id = sanPhamView.Id,
//                Ma = sanPhamView.Ma,
//                Ten = sanPhamView.Ten,
//            };
//            if (_iPhamRepository.UpdateSanPham(obj))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
