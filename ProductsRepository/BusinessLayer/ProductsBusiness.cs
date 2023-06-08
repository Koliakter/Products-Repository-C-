using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsRepository.DataAccessLayer;


namespace ProductsRepository.BusinessLayer
{
    public class ProductsBusiness
    {
        IProductRepository _repository;
        public ProductsBusiness(IProductRepository repository)
        {
            _repository = repository;
        }

        public ProductsBusiness(ProductsBusiness productsBusiness)
        {
        }

        public ProductsBusiness()
        {
        }

        public List<Product> Get() 
        {
            return _repository.Get();
        }
        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Product product)
        {
            return _repository.Add(product);
        }

        public bool Update(Product product)
        {
            return _repository.Update(product);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
