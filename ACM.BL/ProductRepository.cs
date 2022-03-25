using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int id)
        {
            Product product = new Product(id);

            if (id == 2)
            {
                product.Name = "Sunflowers";
                product.Description = "Assorted size set of 4 bright yellow mini sunflowers";
                product.Price = 15.96M;
            }

            Console.WriteLine(product.ToString());

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Insert
                    }
                    else
                    {
                        // Update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
