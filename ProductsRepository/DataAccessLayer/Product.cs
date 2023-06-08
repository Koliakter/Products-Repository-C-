using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsRepository.DataAccessLayer
{
    public class Product
    {
        public int ID;
        public string Name;
        public int Price;
        public string ProType;

        public Product()
        {

        }
        public Product(int id, string name, string proType, int price)
        {
            ID = id;
            Name = name;
            ProType = proType;
            Price = price;
        }
    }
}
