﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{ 
    public class ProductType
    {
        public string Name { get; private set; }

        public ProductType(string name)
        {
            this.Name = name;
        }
    }
}