using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4
{
    public class TransactionRepositories
    {
        static BigDatabaseEntities1 db = new BigDatabaseEntities1();

        public static List<TransactionHistory> getAllTransaction()
        {
            return db.TransactionHistories.ToList<TransactionHistory>();
        }

        public static List<TransactionHistory> getTransactionByEmail(String email)
        {
            return db.TransactionHistories.Where(c => c.CustomerEmail == email).ToList<TransactionHistory>();
        }
    }
}