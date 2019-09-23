using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MiniITXStore
{
    class ShoppingCart
    {
        private readonly List<Part> PartList = new List<Part>();
        public int SessionID { set; get; }
        public Customer CustomerID { get; set; }

        public void AddPartToCart(Part partToAdd)
        {
            PartList.Add(partToAdd);
        }

        public void RemovePartFromCart(Part partToRemove)
        {
            PartList.Remove(partToRemove);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0.00M;
            foreach(Part part in PartList)
            {
                totalPrice += part.Price;
            }
            return totalPrice;
        }
    }
}
