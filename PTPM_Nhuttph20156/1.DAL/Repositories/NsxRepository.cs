//using _1.DAL.Context;
//using _1.DAL.DomainClass;
//using _1.DAL.IRepositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1.DAL.Repositories
//{
//    public class NsxRepository : INsxRepository
//    {
//        private FpolyDBContext _dbContext;
//        List<Nsx> _list;
//        public NsxRepository()
//        {
//            _dbContext = new FpolyDBContext();
//        }
//        public bool AddNsx(Nsx nsx)
//        {
//            if (nsx == null) return false;
//            _dbContext.Nsxes.Add(nsx);
//            _dbContext.SaveChanges();
//            return true;
//        }

//        public bool DeleteNsx(Nsx nsx)
//        {
//            if (nsx == null) return false;
//            var temp = _dbContext.Nsxes.FirstOrDefault(c => c.Id == nsx.Id);
//            _dbContext.Nsxes.Remove(temp);
//            _dbContext.SaveChanges();
//            return true;
//        }

//        public List<Nsx> GetAll()
//        {
//            _list = _dbContext.Nsxes.ToList();
//            return _list;
//        }

//        public bool UpdateNsx(Nsx nsx)
//        {
//            if (nsx == null) return false;
//            var temp = _dbContext.Nsxes.FirstOrDefault(c => c.Id == nsx.Id);
//            temp.Ten = nsx.Ten;
//            temp.Ma = nsx.Ma;
//            _dbContext.Nsxes.Update(temp);
//            _dbContext.SaveChanges();
//            return true;
//        }
//    }
//}
