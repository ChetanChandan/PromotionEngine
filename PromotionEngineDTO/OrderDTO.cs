using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineDTO
{
    public class OrderDTO
    {
        public List<ProductDTO> products { get; set; }

        public OrderDTO()
        {
            products = new List<ProductDTO>();
        }
    }
}
