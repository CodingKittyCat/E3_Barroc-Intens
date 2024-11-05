using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Model
{
    internal class Invoice
    {
        public int Id { get; set; } // invoice nr.
        public string CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double OutstandingBalance { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public Invoice()
        {
        }

        public Invoice(string customerName, DateTime invoiceDate, DateTime dueDate, double totalAmount, double paidAmount, double outstandingBalance, string status, string description)
        {
            CustomerName = customerName;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            OutstandingBalance = outstandingBalance;
            Status = status;
            Description = description;
        }

        public Invoice(int id, string customerName, DateTime invoiceDate, DateTime dueDate, double totalAmount, double paidAmount, double outstandingBalance, string status, string description)
        {
            Id = id;
            CustomerName = customerName;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            TotalAmount = totalAmount;
            PaidAmount = paidAmount;
            OutstandingBalance = outstandingBalance;
            Status = status;
            Description = description;
        }
    }
}
