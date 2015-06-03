using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Core.Models
{
    public interface IPrice
    {
        String Currency1 { get; }
        String Currency2 { get; }
        decimal SellingPrice { get; }
        decimal BuyingPrice { get; }
    }
}
