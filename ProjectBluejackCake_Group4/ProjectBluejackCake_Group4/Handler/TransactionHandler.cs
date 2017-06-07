using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Handler
{
    public class TransactionHandler
    {
        public static void insert(TransactionHistory trans)
        {
            TransactionRepositories.insertTransaction(trans);
        }

        public static List<TransactionHistory> getAllTransaction()
        {
            return TransactionRepositories.getAllTransaction();
        }

        public static List<TransactionHistory> getTransactionByEmail(String email)
        {
            return TransactionRepositories.getTransactionByEmail(email);
        }
    }
}