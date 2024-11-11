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
        public string CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public float TotalAmount { get; set; }
        public bool IsPayed { get; set; }

        public string InvoiceDateToString => InvoiceDate.ToString("dd/MM/yyyy");
        public string DueDateToString => DueDate.ToString("dd/MM/yyyy");

        // Constructor for seeding or creating an invoice
        public Invoice(int id, string customerName, DateTime invoiceDate, DateTime dueDate, float totalAmount, bool isPayed)
        {
            Id = id;
            CustomerName = customerName;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            IsPayed = isPayed;
        }

        // Constructor for creating new invoices without specifying Id
        public Invoice(string customerName, DateTime invoiceDate, DateTime dueDate, float totalAmount, bool isPayed)
        {
            CustomerName = customerName;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            IsPayed = isPayed;
        }
    }
}
