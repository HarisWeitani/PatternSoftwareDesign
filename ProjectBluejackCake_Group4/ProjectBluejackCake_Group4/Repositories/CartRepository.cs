using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Repositories
{
    public class CartRepository
    {
        private static BigDatabaseEntities1 db = new BigDatabaseEntities1();

        public static List<Cart> getAllCart()
        {
            return db.Cart.ToList<Cart>();
        }

        public static int insertCart(Cart ct)
        {
            db.Cart.Add(ct);
            return db.SaveChanges();
        }

        public static int removeCart(Cart ct)
        {
            db.Cart.Remove(ct);
            return db.SaveChanges();
        }

        public static int removeAllCart()
        {
            string sqlTrunc = "TRUNCATE TABLE Cart";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sqlTrunc, conn);
            cmd.ExecuteNonQuery();
            return db.SaveChanges();
        }
    }
}