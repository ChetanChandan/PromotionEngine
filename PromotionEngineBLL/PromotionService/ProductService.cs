using PromotionEngineBLL.PromotionInterface;
using PromotionEngineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineBLL.PromotionService
{
    public class ProductService : IProduct
    {
        public List<ProductDTO> getProducts()
        {
            var products = new List<ProductDTO>();

            products.Add(new ProductDTO() { Id = 1 , ProductName = "A" , Price = 50 , ProductQuantity = 10 });
            products.Add(new ProductDTO() { Id = 2, ProductName = "B", Price = 30 , ProductQuantity = 10 });
            products.Add(new ProductDTO() { Id = 3, ProductName = "C", Price = 20 , ProductQuantity = 10});
            products.Add(new ProductDTO() { Id = 4, ProductName = "D", Price = 15 , ProductQuantity = 10});

            return products;
        }
    }
}
