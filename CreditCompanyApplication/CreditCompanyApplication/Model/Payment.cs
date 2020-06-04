using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CreditCompanyApplication.Model
{
    public class Payment
    {
        public int Cost { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public DateTime MonthId { get; set; }
    }
}
