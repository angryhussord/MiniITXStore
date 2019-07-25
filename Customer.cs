using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    class Customer
    {
        public string Name { get; set; }
        public static int CustomerID { get; set; }
        public Transaction[] TransactionList { get; set; }
    }
}
