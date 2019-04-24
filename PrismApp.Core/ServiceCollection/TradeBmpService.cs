using System.Collections.Generic;
using PrismAppResearch.Models;

namespace PrismApp.Core.ServiceCollection
{
    public class TradeBmpService: ITradeService<TradeBmp>
    {
        #region Implementation of ITradeService<TradeBmp>

        public IList<TradeBmp> GetTrade()
        {
            return new List<TradeBmp>()
            {
                new TradeBmp(1),
                new TradeBmp(2),
                new TradeBmp(3),
                new TradeBmp(4),
            };
        }

        #endregion
    }
}