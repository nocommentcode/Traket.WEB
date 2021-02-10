using System;

namespace Spendings.WEB.Services
{
    public class Expense
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public long CategoryId { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
    }
}