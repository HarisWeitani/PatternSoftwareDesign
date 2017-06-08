using ProjectBluejackCake_Group4.Factory;
using ProjectBluejackCake_Group4.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Controller
{
    public class CakePromotion
    {
        public static void create(String cakeName, int price, int stock, String picture)
        {
            Cake newCake = CakeFactory.create(cakeName, price, stock, picture);

            CakeHandler.create(newCake);
        }

        public static Cake get(String cakeName)
        {
            return CakeHandler.get(cakeName);
        }

        public static List<Cake> getAll()
        {
            return CakeHandler.getAll();
        }


    }
}