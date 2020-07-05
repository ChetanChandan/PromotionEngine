using PromotionEngineBLL.PromotionService;
using PromotionEngineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class PromotionEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to Chetan E-Commerce");
            Console.WriteLine("These are the products available");
            var productService = new ProductService();
            var promotionService = new PromotionService();

            var products = productService.getProducts();

            foreach(var pr in products)
            {
                Console.WriteLine("{0} - {1}", pr.ProductName, pr.Price);
            }

            Console.WriteLine("These Offers we have");
            var promotions = promotionService.getPromotions();
            foreach(var promo in promotions)
            {
                if(promo.Product.Count == 1)
                {
                    Console.WriteLine("{0} - {1} - {2}", promo.Product.FirstOrDefault().ProductName, promo.Product.FirstOrDefault().ProductQuantity ,promo.PromotionPrice);
                }
                else
                {
                    foreach(var item in promo.Product)
                    {
                        Console.Write("{0} - {1} & ", item.ProductName , item.ProductQuantity);
                    }
                    Console.Write("{0}", promo.PromotionPrice);
                }
            }

            //Input from user , give comma separated like A-1 , B-1 , C-1 , D-1
            var orderService = new OrderService();

            Console.WriteLine("Enter the order");

            string ord = Console.ReadLine();
            string[] input = ord.Split(',');           

            var orderResult = orderService.createOrders(input);      
            
            //order checkout 

        }
    }
}
