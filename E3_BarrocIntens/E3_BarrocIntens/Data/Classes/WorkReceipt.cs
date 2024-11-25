using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class WorkReceipt
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<ReceiptMaterial> ReceiptMaterials { get; set; }

        public WorkReceipt(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public WorkReceipt(string description) {
            Description = description;
        }
    }
}
