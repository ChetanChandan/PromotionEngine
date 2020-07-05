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

            products.Add(new ProductDTO("A") { Id = 1 , Price = 50 });
            products.Add(new ProductDTO("B") { Id = 2, Price = 30 });
            products.Add(new ProductDTO("C") { Id = 3, Price = 20 });
            products.Add(new ProductDTO("D") { Id = 4, Price = 15 });

            return products;
        }
    }
}
