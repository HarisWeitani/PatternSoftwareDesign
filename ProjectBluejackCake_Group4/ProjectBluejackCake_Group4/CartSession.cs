using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4
{
    public class CartSession
    {
        public String cakeName;
        public int cakePrice;
        public String chocPlat;
        public String proTitle;
        public int proDiscount;
        public int subTotal;

        public CartSession(String cName, int cPrice, String chocPlate, String pTitle, int pDiscount)
        {
            this.cakeName = cName;
            this.cakePrice = cPrice;
            this.chocPlat = chocPlate;
            this.proTitle = pTitle;
            this.proDiscount = pDiscount;
            this.subTotal = cakePrice - proDiscount;
        }
    }
}