using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    class Customer
    {
        #region Properties
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public Address ShippingAddress = new Address();
        public Address BillingAddress = new Address();
        public string Email;
        public string PhoneNumber;
        #endregion
        #region Methods
        #endregion

    }
}
