using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public float TotalAmount { get; set; }
        public bool IsPayed { get; set; }

        public string InvoiceDateToString => InvoiceDate.ToString("dd/MM/yyyy");
        public string DueDateToString => DueDate.ToString("dd/MM/yyyy");

        public virtual User Customer { get; set; }

        public Invoice()
        {
        }

        // Constructor for seeding or creating an invoice
        public Invoice(int id, int customerId, DateTime invoiceDate, DateTime dueDate, float totalAmount, bool isPayed)
        {
            Id = id;
            CustomerId = customerId;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            IsPayed = isPayed;
        }

        // Constructor for creating new invoices without specifying Id
        public Invoice(int customerId, DateTime invoiceDate, DateTime dueDate, float totalAmount, bool isPayed)
        {
            CustomerId = customerId;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            IsPayed = isPayed;
        }
    }
}
