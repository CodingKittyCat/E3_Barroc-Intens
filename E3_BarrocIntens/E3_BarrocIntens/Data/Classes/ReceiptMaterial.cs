    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace E3_BarrocIntens.Data.Classes
    {
        internal class ReceiptMaterial
        {
            public int ReceiptId { get; set; }
            public WorkReceipt WorkReceipt { get; set; }

            public int MaterialId { get; set;}
            public Material Material { get; set;}

            public int Quantity { get; set;}

            public ReceiptMaterial(int receiptId, int materialId, int quantity)
            {
               ReceiptId = receiptId;
                MaterialId = materialId;
                Quantity = quantity;
            }

            public ReceiptMaterial()
            {

            }
        }
    }
