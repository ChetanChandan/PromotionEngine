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

            products.Add(new ProductDTO("A") { });
            products.Add(new ProductDTO("B") { });
            products.Add(new ProductDTO("C") { });
            products.Add(new ProductDTO("D") { });

            return products;
        }
    }
}
