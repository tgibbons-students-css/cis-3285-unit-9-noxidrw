using System.Collections.Generic;
using System.IO;
using System.Net;
using SingleResponsibilityPrinciple.Contracts;

namespace SingleResponsibilityPrinciple
{
    /**
     * Added my changes to Git
     * 
     * @author William Dixon
     * @version Assignment part 2
     */

    public class URLTradeDataProvider : IURLDataProvider
    {
        public URLTradeDataProvider(string url)
        {
            this.stream = stream;
        }

        public IEnumerable<string> GetTradeData(string url)
        {
            var tradeData = new List<string>();
            var client = new WebClient();
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tradeData.Add(line);
                }
            }
            return tradeData;
        }

        private readonly Stream stream;
    }
}
