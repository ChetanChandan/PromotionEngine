using PromotionEngineBLL.PromotionInterface;
using PromotionEngineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineBLL.PromotionService
{
    public class PromotionService : IPromotion
    {
        public List<PromotionDTO> getPromotions()
        {
            var promotions = new List<PromotionDTO>();
                       
            promotions.Add(new PromotionDTO() { Product = new List<ProductDTO>() { new ProductDTO("A") { ProductQuantity = 3} }, PromotionPrice = 130, IsActive = true });
            promotions.Add(new PromotionDTO() { Product = new List<ProductDTO>() { new ProductDTO("B") { ProductQuantity = 2 } }, PromotionPrice = 45, IsActive = true });
            promotions.Add(new PromotionDTO() { Product = new List<ProductDTO>() { new ProductDTO("C") { ProductQuantity = 1 } , new ProductDTO("D") { ProductQuantity = 1 } }, PromotionPrice = 30, IsActive = true });

            return promotions;
        }
    }
}
