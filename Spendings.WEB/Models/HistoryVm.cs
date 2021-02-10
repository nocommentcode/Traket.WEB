using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spendings.WEB.Models
{
    public class HistoryVm
    {
        public List<MonthlySummary> Months { get; set; }
    }

    public class MonthlySummary
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalBills { get; set; }
    }
}
