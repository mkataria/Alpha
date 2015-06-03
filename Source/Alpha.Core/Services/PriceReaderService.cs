using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha.Core.Interfaces;
using Alpha.Core.Models;
using Alpha.Core.Services.Readers;

namespace Alpha.Core.Services
{
    public class PriceReaderService : ServiceBase, IPriceReaderService
    {
        private readonly List<PriceReader> _readers = new List<PriceReader>();

        public PriceReaderService()
        {
            _readers.Add(new FxExchangeRate());
            _readers.Add(new HdfcReader());
            _readers.Add(new IciciReader("https://itreasury.icicibank.com/forexatclick/forms/MicroCardRateView.aspx"));
        }

        public override void OnStart()
        {
            base.OnStart();
        }

        public override void Process()
        {
            Execute();
        }

        private void Execute()
        {
            foreach (PriceReader reader in _readers)
            {
                reader.ReadFromSource();
            }
        }
    }
}
