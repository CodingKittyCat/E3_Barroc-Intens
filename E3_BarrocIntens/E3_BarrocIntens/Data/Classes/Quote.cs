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
        public bool CustomerAccepted { get; set; } = false;

        public virtual User Customer { get; set; }

        public Quote()
        {
        }

        public Quote(int customerId, DateTime quoteDate, DateTime expirationDate, decimal totalAmount, string status, bool customerAccepted)
        {
            CustomerId = customerId;
            QuoteDate = quoteDate;
            ExpirationDate = expirationDate;
            TotalAmount = totalAmount;
            Status = status;
            CustomerAccepted = customerAccepted;
        }

        public Quote(int id, int customerId, DateTime quoteDate, DateTime expirationDate, decimal totalAmount, string status, bool customerAccepted)
        {
            Id = id;
            CustomerId = customerId;
            QuoteDate = quoteDate;
            ExpirationDate = expirationDate;
            TotalAmount = totalAmount;
            Status = status;
            CustomerAccepted = customerAccepted;
        }
    }
}
