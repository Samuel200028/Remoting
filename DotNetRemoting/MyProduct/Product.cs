﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProduct
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Price { get; set; }
    }
}
