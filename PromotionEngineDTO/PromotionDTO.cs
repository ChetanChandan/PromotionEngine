using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineDTO
{
    public class PromotionDTO
    {
        public List<ProductDTO> ProductUnit { get; set; }

        public decimal PromotionPrice { get; set; }

        public bool IsActive { get; set; }
    }
}
