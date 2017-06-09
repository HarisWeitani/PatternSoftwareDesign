using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Handler
{
    public class CakeHandler
    {
        public static void insertNew(Cake cake)
        {
            CakeRepositories.insertCake(cake);
        }

        public static Cake get(String cakeName)
        {
            return CakeRepositories.getCake(cakeName);
        }

        public static List<Cake> getAll()
        {
            return CakeRepositories.getAllCake();
        }

        public static List<Cake> getAllCake(String cakeName)
        {
            return CakeRepositories.getAllCakeByName(cakeName);
        }

        public static int minusCake(Cake c)
        {
            return CakeRepositories.minusCake(c);
        }
    }
} 