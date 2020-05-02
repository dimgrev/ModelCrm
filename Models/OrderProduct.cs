using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public Product Porduct { get; set; }

        public Order Order { get; set; }
    }
}
