using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; private set; }
        public string Price { get; private set; }
        public bool InStock { get; set; }

        public Product(string name, string price)
        {
            this.Name = name;
            this.Price = price;
            this.InStock = false;
        }
    }

    class ProductHandler
    {
        private List<Product> productList;

        public ProductHandler(List<Product> inventory)
        {
            productList = inventory;
        }

        public void ReviveProduct(Product product)
        {
            foreach (Product prod in productList)
            {
                if (product == prod)
                    prod.InStock = true;
            }
        }

        public void RemoveUnavailableProducts()
        {
            productList.RemoveAll(product => product.InStock == false);
        }
    }
}
