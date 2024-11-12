﻿using E3_BarrocIntens.Model;
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
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
