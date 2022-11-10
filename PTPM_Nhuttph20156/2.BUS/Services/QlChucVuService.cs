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
//    public class QlChucVuService : IChucVuService
//    {
//        private IChucVuRepository _iChucVuRepository;
//        public QlChucVuService()
//        {
//            _iChucVuRepository = new ChucVuRepository();
//        }
//        public string Add(ChucVuView dspView)
//        {
//            if (dspView == null) return "Them khong thanh cong";
//            var obj = new ChucVu()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//            };
//            if (_iChucVuRepository.AddChucVu(obj))
//                return "Them thanh cong";
//            return "Them khong thanh cong";
//        }

//        public string Delete(ChucVuView dspView)
//        {
//            if (dspView == null) return "Xoa khong thanh cong";
//            var obj = new ChucVu()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//            };
//            if (_iChucVuRepository.DeleteChucVu(obj))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<ChucVuView> GetAll()
//        {
//            List<ChucVuView> list = new List<ChucVuView>();
//            list = (from a in _iChucVuRepository.GetAllChucVu()
//                    select new ChucVuView
//                    {
//                        Id=a.Id,
//                        Ma=a.Ma,
//                        Ten=a.Ten,
//                    }).ToList();
//            return list;
//        }

//        public string Update(ChucVuView dspView)
//        {
//            if (dspView == null) return "Sua khong thanh cong";
//            var obj = new ChucVu()
//            {
//                Id = dspView.Id,
//                Ma = dspView.Ma,
//                Ten = dspView.Ten,
//            };
//            if (_iChucVuRepository.UpdateChucVu(obj))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
