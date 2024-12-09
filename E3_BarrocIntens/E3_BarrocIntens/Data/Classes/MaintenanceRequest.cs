
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class MaintenanceRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public DateTime RequestedDateTime { get; set; }
        public List<DateTime> PlannedDateTimes { get; set; } = new List<DateTime>();
        public int? UserId { get; set; }
        public User? User { get; set; }

        public int? WorkReceiptId { get; set; }
        public WorkReceipt? WorkReceipt { get; set; }
        public bool IsClosed { get; set; }
    }
}
