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
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _dBContext;
        List<ChucVu> _chucVuList;
        public ChucVuRepository()
        {
            _dBContext = new FpolyDBContext();
            _chucVuList = new List<ChucVu>();
        }

        public bool AddChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            _dBContext.ChucVus.Add(cv);
            _dBContext.SaveChanges();
            return true;
        }



        public bool DeleteChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            var temp = _dBContext.ChucVus.FirstOrDefault(c => c.MaCv == cv.MaCv);
            _dBContext.ChucVus.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }



        public List<ChucVu> GetAllChucVu()
        {
            _chucVuList = _dBContext.ChucVus.ToList();
            return _chucVuList;
        }

        public ChucVu GetById(Guid Ma)
        {
            throw new NotImplementedException();
        }



        public bool UpdateChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            var temp = _dBContext.ChucVus.FirstOrDefault(c => c.MaCv == cv.MaCv);
            temp.TenCv = cv.TenCv;
            _dBContext.ChucVus.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
