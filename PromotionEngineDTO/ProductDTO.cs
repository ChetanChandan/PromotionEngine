using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineDTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int ProductQuantity { get; set; }

        public ProductDTO(string name)
        {
            this.ProductName = name;
            switch (name)
            {
                case "A":
                    this.Id = 1;
                    this.Price = 50m;

                    break;
                case "B":
                    this.Id = 2;
                    this.Price = 30m;

                    break;
                case "C":
                    this.Id = 3;
                    this.Price = 20m;

                    break;
                case "D":
                    this.Id = 4;
                    this.Price = 15m;
                    break;
            }
        }
    }
}
