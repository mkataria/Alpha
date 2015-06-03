using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha.Core.Models;

namespace Alpha.Core.Services.Readers
{
    abstract class PriceReader:IEnumerable<IPrice>
    {
        protected List<IPrice> Prices;
        protected string DataSource;

        public virtual List<IPrice> ReadFromSource()
        {
            return Prices;
        }
        public IEnumerator<IPrice> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
