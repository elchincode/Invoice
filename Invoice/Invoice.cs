using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVOICE

{
    public class Invoice
    {
        private string account;
        private string customer;
        private string provider;


        public string Article { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set;}


        public  Invoice(string account, string customer, string provider)

        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }

        public decimal CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {

                decimal edv = 0.18m;
                decimal price = Price * Quantity + (Price * edv);
                return price;

            }
            else
            {
                return Price * Quantity;
            }


        }

    }
}
