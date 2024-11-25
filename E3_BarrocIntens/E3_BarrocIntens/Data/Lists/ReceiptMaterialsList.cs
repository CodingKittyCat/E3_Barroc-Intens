using E3_BarrocIntens.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Lists
{
    internal class ReceiptMaterialsList
    {
        List<ReceiptMaterial> receiptMaterialsList = new List<ReceiptMaterial>()
        {
            new ReceiptMaterial(1, 1, 3),
            new ReceiptMaterial(1, 2, 3),
            new ReceiptMaterial(1, 3, 3)

        };
        public List<ReceiptMaterial> GetReceiptMaterials()
        {
            return receiptMaterialsList;
        }
    }
}
