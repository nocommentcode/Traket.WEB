using Spendings.WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spendings.WEB.Models
{
    public class ExpenseVm
    {
        public List<Expense> Expenses { get; set; }
        public List<Category> Categories { get; set; }
        public bool isCreateScreen { get; set; } = false;
        public DateTime? StartDate { get; set; } = null;
        public DateTime? EndDate { get; set; } = null;
    }
}
