using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool AddSach(Sach sach);
        bool UpdateSach(Sach sach);
        bool DeleteSach(Sach sach);
        Sach GetById(Guid id); // phuong thuc tim san pham theo ID
        List<Sach> GetAll();
    }
}
