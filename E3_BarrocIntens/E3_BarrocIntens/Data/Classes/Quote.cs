using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class Quote
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public virtual User Customer { get; set; }
    }
}
