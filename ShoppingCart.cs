using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MiniITXStore
{
    class ShoppingCart
    {
        public Part[] PartList { get; set; }
        public decimal TotalPrice { get; set; }
        public int SessionID { set; get; }
        public Customer CustomerID { get; set; }
        public Part[] ItemSuggestions { get; set; }
    }
}
