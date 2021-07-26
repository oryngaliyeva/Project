﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Reporting
    {
        public static void CountLessThan3(this WareHouse f)
        {
            var result = f.Product.Where(u => u.Count < 3).OrderBy(u => u.Count);
            if (result == null)
            {
                Console.WriteLine("failed");
            }
            foreach (var i in f.Product.Where(u => u.Count < 3).OrderBy(u => u.Count))
            {
                Console.WriteLine(i.Count);

            }

        }
    }
}
