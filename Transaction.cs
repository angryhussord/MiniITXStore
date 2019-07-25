using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    class Transaction
    {
        public Part[] PartList { get; set; }
        public static int TransactionID { get; set; }
        public Customer CustomerID { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
