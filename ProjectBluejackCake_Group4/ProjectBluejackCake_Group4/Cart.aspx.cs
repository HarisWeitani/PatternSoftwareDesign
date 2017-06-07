using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void loadData()
        {
            int grandTotal = 0;

            var cart = (List<CartSession>)Session["cartSessionData"];
            
            foreach(CartSession c in cart)
            {
                grandTotal += c.subTotal;
            }

            txtGrandTotal.Text = grandTotal.ToString();
        }

        protected void viewAllCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}