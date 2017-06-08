    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Repositories
{
    public class CakeRepositories
    {
        private static BigDatabaseEntities1 db = new BigDatabaseEntities1();

        public static List<Cake> getAllCake()
        {
            return db.Cakes.ToList<Cake>();
        }

        public static Cake getCake(String CakeName)
        {
            return db.Cakes.Where(x => x.CakeName == CakeName).FirstOrDefault();
        }

        public static List<Cake> getAllCakeByName(String CakeName)
        {
            return db.Cakes.Where(x => x.CakeName == CakeName).ToList<Cake>();
        }

        public static Cake findCake(String CakeName)
        {
            return db.Cakes.Find(CakeName);
        }

        public static int insertCake(Cake c)
        {
            db.Cakes.Add(c);
            return db.SaveChanges();
        }

        public static int deleteCake(Cake p)
        {
            db.Cakes.Remove(p);
            return db.SaveChanges();
        }

        public static void updateCake(Cake p, String cakeName, int price, int stock, String picture)
        {
            p.CakeName = cakeName;
            p.Price = price;
            p.Stock = stock;
            p.Picture = picture;
        }

        public static int updateCake(List<Cake> cake,String cakeName,int price, int stock, String picture)
        {
            foreach(Cake p in cake)
            {
                updateCake(p, cakeName, price, stock, picture);
            }

            return db.SaveChanges();
        }
    }
}