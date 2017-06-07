using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Factory
{
    public class TransactionFactory
    {
        public static TransactionHistory create(String custemail, String custname, String cakename, int cakeprice, String chocplat, String protitle, int prodiscount, int subtotal)
        {
            return new TransactionHistory()
            {
                CustomerEmail = custemail,
                TransactionDate = DateTime.Now,
                CustomerName = custname,
                CakeName = cakename,
                CakePrice = cakeprice,
                ChocolatePlateGreeting = chocplat,
                PromotionTitle = protitle,
                PromotionDiscount = prodiscount,
                SubTotal = subtotal
            };
        }
    }
}