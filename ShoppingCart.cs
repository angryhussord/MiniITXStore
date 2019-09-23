using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MiniITXStore
{
    class ShoppingCart
    {
        private readonly List<Part> PartList = new List<Part>();
        public decimal TotalPrice { get; set; }
        public int SessionID { set; get; }
        public Customer CustomerID { get; set; }

        public void AddPartToCart(Part partToAdd)
        {
            PartList.Add(partToAdd);
        }
    }
}
