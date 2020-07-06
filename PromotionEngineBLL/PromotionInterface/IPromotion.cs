using PromotionEngineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineBLL.PromotionInterface
{
    public interface IPromotion
    {
        List<PromotionDTO> getPromotions();

        decimal? checkApplyPromotion(List<ProductDTO> products);
    }
}
