using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PrismApp.Core.ServiceCollection
{
    public interface ITradeService<T>
    {
        IList<T> GetTrade();

    }

    public abstract class TradeService<T>
    {


    }
}