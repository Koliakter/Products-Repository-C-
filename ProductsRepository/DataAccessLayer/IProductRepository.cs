using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsRepository.DataAccessLayer
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product Get(int id);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        bool Delete(int id);
    }
}
