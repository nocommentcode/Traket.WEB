using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spendings.WEB.Models
{
    public class Bill
    {
        public long Id { get; set; }
        public DateTimeOffset BillingStart { get; set; }
        public DateTimeOffset? BillingEnd { get; set; }
        public decimal Amount { get; set; }
        public int DayOfMonthDebited { get; set; }
        public string Name { get; set; }
    }
}
