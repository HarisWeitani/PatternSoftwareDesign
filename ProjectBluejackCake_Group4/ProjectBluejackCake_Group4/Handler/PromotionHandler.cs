using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Handler
{
    public class PromotionHandler
    {
        public static void create(Promotion promo)
        {
            PromotionRepositories.insertPromo(promo);
        }

        public static Promotion getPromo(String title)
        {
            return PromotionRepositories.getPromo(title);
        }

        public static List<Promotion> getAll()
        {
            return PromotionRepositories.getAllPromo();
        }
    }
}