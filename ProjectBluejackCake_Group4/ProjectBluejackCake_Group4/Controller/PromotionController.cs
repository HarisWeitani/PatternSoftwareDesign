using ProjectBluejackCake_Group4.Factory;
using ProjectBluejackCake_Group4.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Controller
{
    public class PromotionController
    {
        public static void create(String title,String desc,int discount)
        {
            Promotion newPromo = PromotionFactory.create(title, desc, discount);

            PromotionHandler.create(newPromo);
        }

        public static Promotion get(String title)
        {
            return PromotionHandler.getPromo(title);
        }

        public static List<Promotion> getAll()
        {
            return PromotionHandler.getAll();
        }


    }
}