﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +"Eklendi.");
         }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+"Güncellendi.");
        }
    }
}
