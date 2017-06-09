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
            db.Configuration.ValidateOnSaveEnabled = false;
            return db.SaveChanges();
        }

        public static int deleteCake(Cake c)
        {
            db.Cakes.Remove(c);
            return db.SaveChanges();
        }

        public static int updateCake(Cake c, String CakeName, int Price, int Stock, String Picture)
        {
            c.CakeName = CakeName;
            c.Price = Price;
            c.Stock = Stock;
            c.Picture = Picture;

            db.Cakes.Attach(c);
            db.Entry(c).State = System.Data.Entity.EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            return db.SaveChanges();
        }

        public static int updateCake(List<Cake> cake, string cakeName, int cakePrice, int cakeStock, string cakePic)
        {
            foreach (Cake c in cake)
            {
                updateCake(c, cakeName, cakePrice, cakeStock, cakePic);
            }
            db.Configuration.ValidateOnSaveEnabled = false;
            return db.SaveChanges();
        }

        public static int minusCake(Cake c)
        {
            c.Stock -= 1;
            return db.SaveChanges();
        }
    }
}