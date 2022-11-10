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
//    public class QLCtSanPhamService : ICtSanPhamService
//    {
//        private IChiTietSPRepository _ichiTietSPRepository;
//        private INsxRepository _insxRepository;
//        private ISanPhamRepository _iSanPhamRepository;
//        private IMauSacRepository _iMauSacRepository;
//        private IDspRepository _iDspRepository;
//        public QLCtSanPhamService()
//        {
//            _ichiTietSPRepository = new ChiTietSPRepository();
//            _insxRepository = new NsxRepository();
//            _iSanPhamRepository = new SanPhamRepository();
//            _iMauSacRepository = new MauSacRepository();
//            _iDspRepository = new DspRepository();
//        }
//        public string Add(CtSanPhamView obj)
//        {
//            if (obj == null) return "Them khong thanh cong";
//            var chiTietSanPham = new ChiTietSp()
//            {
//                Id = obj.Id,
//                IdSp = obj.IdSp,
//                IdNsx = obj.IdNsx,
//                IdMauSac = obj.IdMauSac,
//                IdDongSp = obj.IdDongSp,
//                NamBh = obj.NamBh,
//                MoTa = obj.MoTa,
//                SoLuongTon = obj.SoLuongTon,
//                GiaNhap = obj.GiaNhap,
//                GiaBan = obj.GiaBan,

//            };
//            if (_ichiTietSPRepository.AddChiTietSP(chiTietSanPham))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(CtSanPhamView obj)
//        {
//            if (obj == null) return "Xoa khong thanh cong";
//            var chiTietSanPham = new ChiTietSp()
//            {
//                Id = obj.Id,
//                IdSp = obj.IdSp,
//                IdNsx = obj.IdNsx,
//                IdMauSac = obj.IdMauSac,
//                IdDongSp = obj.IdDongSp,
//                NamBh = obj.NamBh,
//                MoTa = obj.MoTa,
//                SoLuongTon=obj.SoLuongTon,
//                GiaNhap = obj.GiaNhap,
//                GiaBan = obj.GiaBan,

//            };
//            if (_ichiTietSPRepository.DeleteChiTietSP(chiTietSanPham))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<CtSanPhamView> GetAll()
//        {
//            List<CtSanPhamView> lstPhamViews = new List<CtSanPhamView>();
//            // viet 1 cau linq de gan gia tri tuong ung prop cua san pham view
//            lstPhamViews =
//                (from a in _ichiTietSPRepository.GetAllChiTietSP()                 
//                 join b in _iSanPhamRepository.GetAll() on a.IdSp equals b.Id
//                 join c in _iDspRepository.GetAll() on a.IdDongSp equals c.Id
//                 join d in _iMauSacRepository.GetAll() on a.IdMauSac equals d.Id
//                 join e in _insxRepository.GetAll() on a.IdNsx equals e.Id
//                 select new CtSanPhamView
//                 {
//                     Id = a.Id,
//                     IdSp = b.Id,
//                     IdNsx = e.Id,
//                     IdMauSac = d.Id,
//                     IdDongSp = c.Id,
//                     NamBh = a.NamBh,
//                     MoTa = a.MoTa,
//                     SoLuongTon=a.SoLuongTon,
//                     GiaNhap = a.GiaNhap,
//                     GiaBan = a.GiaBan,
//                 }
//                ).ToList();
//            return lstPhamViews;
//        }

//        public string Update(CtSanPhamView obj)
//        {
//            if (obj == null) return "Sua khong thanh cong";
//            var chiTietSanPham = new ChiTietSp()
//            {
//                Id = obj.Id,
//                IdSp = obj.IdSp,
//                IdNsx = obj.IdNsx,
//                IdMauSac = obj.IdMauSac,
//                IdDongSp = obj.IdDongSp,
//                NamBh = obj.NamBh,
//                MoTa = obj.MoTa,
//                SoLuongTon = obj.SoLuongTon,
//                GiaNhap = obj.GiaNhap,
//                GiaBan = obj.GiaBan,

//            };
//            if (_ichiTietSPRepository.UpdateChiTietSP(chiTietSanPham))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
