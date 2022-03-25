using ACM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        // public string Name { get; set; }
        private string _name;
        public string Name 
        { 
            get
            {
                // return StringHandler.InsertSpaces(_name);
                return _name.InsertSpaces();
            }
            set
            {
                _name = value; 
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(Name)) isValid = false;
            if (Price == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
