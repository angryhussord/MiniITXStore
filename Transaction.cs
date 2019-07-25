using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    enum PaymentTypes { Credit, Debit, Cash, PayPal, Venmo, CashApp }
    class Transaction
    {
        public Part[] PartList { get; set; }
        public int TransactionID { get; set; }
        public Customer CustomerID { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public PaymentTypes PaymentType { get; set; }
    }
}
