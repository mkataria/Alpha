using System;
using System.Collections.Generic;
using System.Net;
using Alpha.Core.Models;
using HtmlAgilityPack;

namespace Alpha.Core.Services.Readers
{
    class IciciReader : PriceReader
    {

        public IciciReader(string url)
        {
            DataSource = url;
        }

        public override List<IPrice> ReadFromSource()
        {
            var client = new WebClient();
            var data = client.DownloadString(DataSource);
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            var table = doc.DocumentNode.SelectSingleNode("//table[@id='dgMicroRateCard']");
            if (table == null)
                throw new Exception("table - dgMicroRateCard not found");
            var rowIndex = -1;
            const int dataToBeFoundAt = 2;
            const int currencyNameCellIndex = 0;
            const int buyingRateCellIndex = 1;
            const int sellingRateCellIndex = 7;


            Prices = new List<IPrice>();

            foreach (var rows in table.SelectNodes("tr"))
            {
                rowIndex++;
                if (rowIndex < dataToBeFoundAt)
                    continue;

                
                var cells = rows.SelectNodes("td");
                var currency = ReadCurrency(cells[currencyNameCellIndex].InnerText);
                var buyingRate = ReadCurrencyValue(cells[buyingRateCellIndex].InnerText);
                var sellingRate = ReadCurrencyValue(cells[sellingRateCellIndex].InnerText);
                Prices.Add(new Price("INR", currency, sellingRate, buyingRate));
            }
            return Prices;
        }

        private static decimal ReadCurrencyValue(string data)
        {
            decimal value;
            try
            {
                value = Convert.ToDecimal(data);
            }
            finally { }
            return value;
        }

        private static string ReadCurrency(string data)
        {
            string ccy;
            try
            {
                ccy = data.Substring(data.IndexOf("(", StringComparison.Ordinal) + 1, 3);
            }
            finally
            {
            }
            return ccy;
        }
    }
}
