using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4
{
    public class CartSession
    {
        public String cakeName { get; set; }
        public int cakePrice { get; set; }
        public String chocPlat { get; set; }
        public String proTitle { get; set; }
        public int proDiscount { get; set; }
        public int subTotal { get; set; }

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