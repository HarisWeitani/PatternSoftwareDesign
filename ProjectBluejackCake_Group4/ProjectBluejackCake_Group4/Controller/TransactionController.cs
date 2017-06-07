using ProjectBluejackCake_Group4.Factory;
using ProjectBluejackCake_Group4.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Controller
{
    public class TransactionController
    {
        public static void create(String custemail, String custname, String cakename, int cakeprice, String chocplat, String protitle, int prodiscount, int subtotal)
        {
            TransactionHistory trans = TransactionFactory.create(custemail, custname, cakename, cakeprice, chocplat, protitle, prodiscount, subtotal);
            TransactionHandler.insert(trans);
        }

        public static List<TransactionHistory> getAllTransaction()
        {
            return TransactionHandler.getAllTransaction();
        }

        public static List<TransactionHistory> getTransactionByEmail(String email)
        {
            return TransactionHandler.getTransactionByEmail(email);
        }
    }
}