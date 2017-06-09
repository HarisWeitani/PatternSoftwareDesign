using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Repositories
{
    public class PromotionRepositories
    {
        private static BigDatabaseEntities1 db = new BigDatabaseEntities1();

        public static List<Promotion> getAllPromo()
        {
            return db.Promotions.ToList<Promotion>();
        }

        public static Promotion getPromo(String title)
        {
            return db.Promotions.Where(x => x.Title == title).FirstOrDefault();
        }

        public static List<Promotion> getAllPromoByTitle(String title)
        {
            return db.Promotions.Where(x => x.Title == title).ToList<Promotion>();
        }

        public static int insertPromo(Promotion x)
        {
            db.Promotions.Add(x);
            return db.SaveChanges();
        }

        public static Promotion findTitle(String title)
        {
            return db.Promotions.Where(x => x.Title == title).FirstOrDefault();
        }

        public static int deletePromot(Promotion x)
        {
            db.Promotions.Remove(x);
            return db.SaveChanges();
        }

        public static void updatePromo(Promotion x, String title, String descrip, int discount)
        {
            x.Title = title;
            x.Description = descrip;
            x.Discount = discount;
        }

        public static int updatePromo(List<Promotion> prom, String title, String descrip, int discount)
        {
            foreach (Promotion x in prom)
            {
                updatePromo(x, title, descrip, discount);
            }

            return db.SaveChanges();
        }
    }
}