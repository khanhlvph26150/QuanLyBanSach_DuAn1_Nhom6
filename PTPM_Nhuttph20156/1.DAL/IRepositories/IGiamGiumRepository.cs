using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INsxRepository
    {
        bool AddGiamGia(GiamGium gg);
        bool UpdateGiamGia(GiamGium gg);
        bool DeleteGiamGia(GiamGium gg);
        GiamGium GetById(Guid Ma); // phuong thuc tim san pham theo ID

        List<GiamGium> GetAll();

    }
}
