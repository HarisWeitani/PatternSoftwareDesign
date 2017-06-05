using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Factory
{
    public class CartFactory
    {
        public static Cart create(String CakeName, int Price, String cgp, String Promotion, String Discount)
        {
            return new Cart()
            {
                CakeName = CakeName,
                Price = Price,
                cgp = cgp,
                Promotion = Promotion,
                Discount = Discount
            };
        }
    }
}