using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spendings.WEB.Models
{
    public class Income
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset DateReceived { get; set; }
        public string Employer { get; set; }
    }
}
