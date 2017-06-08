using ProjectBluejackCake_Group4.Controller;
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
            List<CartSession> cart = (List<CartSession>)Session["cartSessionData"];

            int index = e.RowIndex;

            cart.RemoveAt(index);

            erMessage.Text = "Remove Success!";

            loadData();
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            Member m = (Member)Session["userLogin"];

            DateTime date = DateTime.Now.Date;
            String custEmail = m.Email;

            List<CartSession> cart = (List<CartSession>)Session["cartSessionData"];

            foreach(CartSession c in cart)
            {
                TransactionController.create(custEmail, date, m.Name, c.cakeName, c.cakePrice, c.chocPlat, c.proTitle, c.proDiscount, c.subTotal);

                Cake ca =CakeController.get(c.cakeName);
                CakeController.minusCake(ca);
            }

            Session["cartSessionData"] = null;
            Session["cartSessionData"] = new List<CartSession>();

            erMessage.Text = "Checkout Success!";
            loadData();
        }
    }
}