using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }

        public OrderItem(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;

            return isValid;
        }
    }
}
