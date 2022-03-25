using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }

        public Order(int id)
        {
            Id = id;
            OrderItems = new List<OrderItem>();
        }

        public int Id { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public string Log()
        {
            throw new NotImplementedException();
        }

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate != null) isValid = false;

            return isValid;
        }
    }
}
