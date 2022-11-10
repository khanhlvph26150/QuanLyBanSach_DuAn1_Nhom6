using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepository
    {
        List<ChucVu> GetAllChucVu();
        ChucVu GetById(Guid Ma); // phuong thuc tim san pham theo ID

        bool AddChucVu(ChucVu cv);
        bool UpdateChucVu(ChucVu cv);
        bool DeleteChucVu(ChucVu cv);
    }
}
