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

        public decimal? checkApplyPromotion(List<ProductDTO> products)
        {
            decimal? total = 0;      

            var promotions = getPromotions();
            //var prodList = products.Select(p => p.ProductName).ToList();           

            foreach (var promo in promotions)
            {
                if (promo.Product.Count == 1)
                {
                    foreach (var prod in promo.Product)
                    {
                        //find prods in order
                        var prodsInOrder = products.Where(p => p.ProductName.Equals(prod.ProductName)).FirstOrDefault();

                        if(prodsInOrder.ProductQuantity >= prod.ProductQuantity)
                        {
                            var promoQuant = prod.ProductQuantity;
                            var noOfPromo = prodsInOrder.ProductQuantity / promoQuant;
                            var remainingProds = prodsInOrder.ProductQuantity % promoQuant;

                            if (noOfPromo > 0)
                                total = total + (noOfPromo * promo.PromotionPrice);

                            if (remainingProds > 0)
                                total = total + (remainingProds * prodsInOrder.Price);
                        }
                        else
                        {
                            total = total + (prodsInOrder.ProductQuantity * prodsInOrder.Price);
                        }
                    }
                }
                else//double product promo
                {
                    var promoProdCount = promo.Product.Count;
                    var promoProdList = new List<ProductDTO>();

                    var promQuantity = promo.Product.Sum(s => s.ProductQuantity);

                    foreach (var prod in promo.Product)
                    {
                        var findDoublePromoProds = products.Where(p => p.ProductName.Equals(prod.ProductName)).FirstOrDefault();

                        if(findDoublePromoProds != null)
                        {
                            promoProdList.Add(findDoublePromoProds);
                        }
                    }

                    var promProdQuant = promoProdList.Sum(p => p.ProductQuantity);

                    //if count of product is not equal then no promo
                    if(promoProdList.Count != promoProdCount)
                    {
                        foreach(var p in promoProdList)
                        {
                            total = total + (p.ProductQuantity * p.Price);
                        }
                    }
                    else
                    {
                        if(promProdQuant % promQuantity == 0)
                        {
                            total = total + ((promProdQuant / promQuantity) * promo.PromotionPrice);
                        }
                        else
                        {
                            var promtobeApplied = promProdQuant / promQuantity;
                            var remProd = promProdQuant % promQuantity;

                            if(promtobeApplied > 0)
                                total = total + (promtobeApplied * promo.PromotionPrice);

                            var productLeft = promoProdList.Where(p => p.ProductQuantity > remProd).FirstOrDefault();

                            if(productLeft != null && remProd > 0)
                                total = total + (productLeft.Price * remProd);
                        }
                    }
                }
            }

            return total;
        }       
    }
}
