namespace PrismApp.Core.Models
{
    public class TradeBmp
    {
        public TradeBmp(int tradeId)
        {
            TradeId = tradeId;
        }

        public int TradeId { get; set; }
        public string DisplayTrade => $"Trade id {TradeId}";
    }
}