using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Model
{
    public class ProductModelUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
