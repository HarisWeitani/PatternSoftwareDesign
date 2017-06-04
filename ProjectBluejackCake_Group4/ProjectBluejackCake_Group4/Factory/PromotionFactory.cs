using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Factory
{
    public class PromotionFactory
    {
        public static Promotion create(String title, String description, int discount)
        {
            return new Promotion()
            {
                Title = title,
                Description = description,
                Discount = discount
            };
        }
    }
}