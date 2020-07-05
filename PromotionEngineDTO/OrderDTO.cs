using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineDTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public List<ProductDTO> products { get; set; }
    }
}
