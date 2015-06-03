using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Core.Models
{
    public class Price:IPrice
    {
        public Price(string currency1, string currency2, decimal sellingPrice, decimal buyingPrice)
        {
            Currency1 = currency1;
            Currency2 = currency2;
            SellingPrice = sellingPrice;
            BuyingPrice = buyingPrice;
        }
        public string Currency1 { get; private set; }
        public string Currency2 { get; private set; }
        public decimal SellingPrice { get; private set; }
        public decimal BuyingPrice { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}/{1} - B.P={2}, S.P={3} ", Currency1, Currency2, BuyingPrice, SellingPrice);
        }
    }


}
