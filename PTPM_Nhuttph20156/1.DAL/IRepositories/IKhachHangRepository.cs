using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        bool AddKhachHang(KhachHang kh);
        bool UpdateKhachHang(KhachHang kh);
        bool DeleteKhachHang(KhachHang kh);
        KhachHang GetById(Guid Ma); // phuong thuc tim san pham theo ID
        List<KhachHang> GetAll();
    }
}
