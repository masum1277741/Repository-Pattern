﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS.Models
{
    public class Product: BaseNature
    {
        public string processorName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Model { get; set; }
    }
}
