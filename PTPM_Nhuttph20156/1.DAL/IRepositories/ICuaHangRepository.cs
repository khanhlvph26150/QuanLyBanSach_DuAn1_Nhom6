using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepository
    {
        List<CuaHang> GetAllCuaHang();
        CuaHang GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddCuaHang(CuaHang ch);
        bool UpdateCuaHang(CuaHang ch);
        bool DeleteCuaHang(CuaHang ch);
    }
}
