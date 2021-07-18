﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class OpenWareHouse:WareHouse

    {
        public event EventHandler<EventArgs> Notify = delegate { };
        public override bool IsAddProduct(Product product, int count)
        {
            if(!(product is BulkProduct))
            {
                base.IsAddProduct(product, count);
                return true;
                Notify?.Invoke(this, new EventArgs { DateTime = DateTime.Now, NameofProduct = product.Name });
            }
            
                try

                { if(product is BulkProduct)
                    {
                        throw new Exception("Сыпучие продукты в Открытом складе");
                    }
                 
                }
                catch(Exception e)
                {
                      Console.WriteLine($"Ошибка:{e.Message}");
                }
                
                return false;
            

        }
    }

}
