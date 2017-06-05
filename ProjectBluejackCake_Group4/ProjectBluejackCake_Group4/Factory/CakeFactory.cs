using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Factory
{
    public class CakeFactory
    {
        public static Cake create(String CakeName, int Price, int Stock, String Picture)
        {
            return new Cake()
            {
                CakeName = CakeName,
                Price = Price,
                Stock = Stock,
                Picture = Picture
            };
        }
    }
}