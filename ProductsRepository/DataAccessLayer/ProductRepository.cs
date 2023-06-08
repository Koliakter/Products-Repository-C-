using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsRepository.DataAccessLayer
{

    public class ProductRepository : IProductRepository 
    {
        List<Product> ProductList = new List<Product>()
        {
            new Product(1, "Walton Primo S8", "SmartPhone", 20990),
            new Product(2, "Walton TAMARIND EX311G", "Laptop", 56952),
            new Product(3, "Walton WFC-3F5-GDEL-XX", "Refrigerator & Freezer", 45621),
            new Product(4, "Walton WD55RUG", "Smart TV", 84900),
            new Product(5, "Walton WEO-J28EDK", "Microwave and Electric Oven", 8500)
        };
        public List<Product> Get()
        {
            return ProductList.OrderBy(x => x.Name).ToList();
        }
        public Product Get(int id)
        {
            Product oProduct = ProductList.Where(x => x.ID == id).FirstOrDefault();
            return oProduct;
        }

        public bool Add(Product product)
        {
            ProductList.Add(product);
            return true;
        }

        public bool Update(Product product)
        {
            bool isExecuted = false;
            Product oProduct = ProductList.Where(x => x.ID == product.ID).FirstOrDefault();
            if (oProduct != null)
            {
                ProductList.Remove(oProduct);
                ProductList.Add(product);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Product oProduct = ProductList.Where(x => x.ID == id).FirstOrDefault();
            if (oProduct != null)
            {
                ProductList.Remove(oProduct);
                isExecuted = true;
            }
            return isExecuted;
        }

        bool IProductRepository.Delete(Product product)
        {
            throw new NotImplementedException();
        }


    }
}
