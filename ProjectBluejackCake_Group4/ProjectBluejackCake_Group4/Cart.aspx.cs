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
            loadData();
        }

        void loadData()
        {
            int grandTotal = 0;

            List<CartSession> cart = (List<CartSession>)Session["cartSessionData"];

            foreach (CartSession c in cart)
            {
                grandTotal += c.subTotal;
            }

            viewAllCart.DataSource = cart.ToList();
            viewAllCart.DataBind();

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