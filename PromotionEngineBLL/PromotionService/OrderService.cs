using PromotionEngineBLL.PromotionInterface;
using PromotionEngineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineBLL.PromotionService
{
    public class OrderService : IOrder
    {
        public OrderDTO createOrders(string[] ord)
        {
            var order = new OrderDTO();

            if(ord.Length > 0)
            {
                for (int i = 0; i < ord.Length; i++)
                {
                    string[] splitOrder = ord[i].Split('-');

                    var name = splitOrder[0];
                    var orderQuantity = Convert.ToInt32(splitOrder[1]);

                    order.products.Add(new ProductDTO(name) { ProductQuantity = orderQuantity });
                }
            }

            return order;
        }

        public decimal? orderApplyPromotionCheckout(OrderDTO order)
        {
            var products = order.products;
            var promotion = new PromotionService();

            decimal? totalAmount = promotion.checkApplyPromotion(products);
            
            return totalAmount;
        }
    }
}
