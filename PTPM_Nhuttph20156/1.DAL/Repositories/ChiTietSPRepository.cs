//using _1.DAL.Context;
//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Repositories
//{
//    public class ChiTietSPRepository : IChiTietSPRepository
//    {
//        private FpolyDBContext _dbContext;
//        public ChiTietSPRepository()
//        {
//            _dbContext = new FpolyDBContext();
//        }
       

//        public bool AddChiTietSP(ChiTietSp ctSP)
//        {
//            if (ctSP == null) return false;
//            _dbContext.ChiTietSps.Add(ctSP);
//            _dbContext.SaveChanges();
//            return true;
//        }
//        public bool DeleteChiTietSP(ChiTietSp ctSP)
//        {
//            if (ctSP == null) return false;
//            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == ctSP.Id);
//            _dbContext.Remove(tempobj);
//            _dbContext.SaveChanges();
//            return true;
//        }

        

//        public List<ChiTietSp> GetAllChiTietSP()
//        {
//            return _dbContext.ChiTietSps.ToList();
//        }

//        public ChiTietSp GetById(Guid id)
//        {
//            throw new NotImplementedException();
//        }


//        public bool UpdateChiTietSP(ChiTietSp ctSP)
//        {
//            if (ctSP == null) return false;
//            //obj.Id = Guid.NewGuid();// tu dong zen khoa chinh
//            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == ctSP.Id);
//            tempobj.IdSp = ctSP.IdSp;
//            tempobj.IdDongSp = ctSP.IdSp;
//            tempobj.IdMauSac = ctSP.IdMauSac;
//            tempobj.IdNsx = ctSP.IdNsx;
//            tempobj.IdDongSp = ctSP.IdDongSp;
//            tempobj.NamBh = ctSP.NamBh;
//            tempobj.MoTa = ctSP.MoTa;
//            tempobj.SoLuongTon = ctSP.SoLuongTon;
//            tempobj.GiaNhap = ctSP.GiaNhap;
//            tempobj.GiaBan = ctSP.GiaBan;
           
            
//            _dbContext.Update(tempobj);
//            _dbContext.SaveChanges();
//            return true;
//        }
//    }
//}
