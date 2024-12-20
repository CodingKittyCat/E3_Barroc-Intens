﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Classes
{
    internal class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Stock { get; set; }

        public ICollection<ReceiptMaterial> ReceiptMaterials { get; set; }

        public int TotalQuantity => ReceiptMaterials?.Sum(rm => rm.Quantity) ?? 0;
        public Material(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }


    }
}
