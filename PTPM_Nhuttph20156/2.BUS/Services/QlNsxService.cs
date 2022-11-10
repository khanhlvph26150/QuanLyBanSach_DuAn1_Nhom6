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
//    public class QlNsxService : INsxService
//    {
//        private INsxRepository _iNsxRepository;
//        public QlNsxService()
//        {
//            _iNsxRepository = new NsxRepository();
//        }
//        public string Add(NsxView nsxView)
//        {
//            if (nsxView == null)
//            {
//                return "Them khong thanh cong";
//            }
//            var temp = new Nsx()
//            {
//                Id = nsxView.Id,
//                Ma = nsxView.Ma,
//                Ten = nsxView.Ten,
//            };
//            if (_iNsxRepository.AddNsx(temp))
//                return "Them thanh cong";
//            return "Them khong thanh cong";

//        }

//        public string Delete(NsxView nsxView)
//        {
//            if (nsxView == null)
//            {
//                return "Xoa khong thanh cong";
//            }
//            var temp = new Nsx()
//            {
//                Id=nsxView.Id,
//                Ma =nsxView.Ma,
//                Ten = nsxView.Ten,
//            };
//            if (_iNsxRepository.DeleteNsx(temp))
//                return "Xoa thanh cong";
//            return "Xoa khong thanh cong";
//        }

//        public List<NsxView> GetAll()
//        {
//            List<NsxView> nsxView = new List<NsxView>();
//            nsxView = (from n in _iNsxRepository.GetAll()
//                       select new NsxView
//                       {
//                           Id = n.Id,
//                           Ma = n.Ma,
//                           Ten = n.Ten,
//                       }).ToList();
//            return nsxView;
//        }

//        public string Update(NsxView nsxView)
//        {
//            if (nsxView == null)
//            {
//                return "Sua khong thanh cong";
//            }
//            var temp = new Nsx()
//            {
//                Id = nsxView.Id,
//                Ma =nsxView.Ma,
//                Ten = nsxView.Ten,
//            };
//            if (_iNsxRepository.UpdateNsx(temp))
//                return "Sua thanh cong";
//            return "Sua khong thanh cong";
//        }
//    }
//}
