using FJFMarketing.Models.Enums;
using System;

namespace FJFMarketing.Models.Entities
{
    public class Tradelog: BaseEntity
    {
        public TradeLogTypes LogType { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}
