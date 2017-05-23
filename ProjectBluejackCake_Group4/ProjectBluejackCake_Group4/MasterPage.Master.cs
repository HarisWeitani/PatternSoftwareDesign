using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kalo dia load, langsung load time juga
            lblDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:sstt");

            Member currentUser = (Member)Session["userLogin"];
            if (currentUser == null)
            {
                guestPagesState(true);
                lblUserLogin.Text = "Stranger..";
            }
            else if (currentUser != null)
            {
                lblUserLogin.Text = currentUser.Name;
                if (currentUser.Type == "Admin")
                {
                    adminPagesState(true);
                }
                else if (currentUser.Type == "Customer")
                {
                    customerPagesState(true);
                }
            }
        }

        public void guestPagesState(bool state)
        {
            hlHome.Visible = state;
            hlLogin.Visible = state;
            hlRegister.Visible = state;
            hlForgotPassword.Visible = state;
            hlCake.Visible = state;

            hlPromotion.Visible = !state;
            hlAddPromotion.Visible = !state;
            hlUpdatePromotion.Visible = !state;
            hlAddCake.Visible = !state;
            hlUpdateCake.Visible = !state;
            hlProfile.Visible = !state;
            hlChangePassword.Visible = !state;
            hlViewCustomer.Visible = !state;
            hlCart.Visible = !state;
            hlTransaction.Visible = !state;
            hlTransactionReport.Visible = !state;
            hlLogout.Visible = !state;
        }

        public void adminPagesState(bool state)
        {
            hlHome.Visible = state;
            hlPromotion.Visible = state;
            hlAddPromotion.Visible = state;
            hlUpdatePromotion.Visible = state;
            hlCake.Visible = state;
            hlAddCake.Visible = state;
            hlUpdateCake.Visible = state;
            hlProfile.Visible = state;
            hlChangePassword.Visible = state;
            hlViewCustomer.Visible = state;
            hlTransaction.Visible = state;
            hlTransactionReport.Visible = state;
            hlLogout.Visible = state;

            hlLogin.Visible = !state;
            hlRegister.Visible = !state;
            hlForgotPassword.Visible = !state;
            hlCart.Visible = !state;
        }
        public void customerPagesState(bool state)
        {
            hlHome.Visible = state;
            hlCake.Visible = state;
            hlProfile.Visible = state;
            hlChangePassword.Visible = state;
            hlCart.Visible = state;
            hlTransaction.Visible = state;
            hlTransactionReport.Visible = state;
            hlLogout.Visible = state;

            hlLogin.Visible = !state;
            hlRegister.Visible = !state;
            hlForgotPassword.Visible = !state;
            hlPromotion.Visible = !state;
            hlAddPromotion.Visible = !state;
            hlUpdatePromotion.Visible = !state;
            hlAddCake.Visible = !state;
            hlUpdateCake.Visible = !state;
            hlViewCustomer.Visible = !state;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:sstt");
        }
    }
}