﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class OpenWareHouse:WareHouse

    {
        public override bool IsAddProduct(Product product, int count)
        {
            if(!(product is BulkProduct))
            {
                base.IsAddProduct(product, count);
                return true;
            }
            else
            {
                try
                {
                 base.IsAddProduct(product, count);
                }
                catch
                {
                      Console.WriteLine("Voznikla");
                }
                
                return false;
            }

        }
    }

}
