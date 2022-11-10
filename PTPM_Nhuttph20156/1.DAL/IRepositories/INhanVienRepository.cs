using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool AddNhanVien(NhanVien nv);
        bool UpdateNhanVien(NhanVien nv);
        bool DeleteNhanVien(NhanVien nv);
        NhanVien GetById(Guid Ma); // phuong thuc tim san pham theo ID
        List<NhanVien> GetAll();
    }
}
