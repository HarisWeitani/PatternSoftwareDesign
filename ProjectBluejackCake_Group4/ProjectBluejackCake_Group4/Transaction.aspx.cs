using ProjectBluejackCake_Group4.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["userLogin"];
            if (currentUser == null)
            {
                Response.Redirect("Home.aspx");
            }
            else if (currentUser != null)
            {
                if (currentUser.Type == "Admin")
                {
                    lblTransaction.Text = "all the customer";
                    loadDataAdmin();
                }
                else if (currentUser.Type == "Customer")
                {
                    lblTransaction.Text = "you";
                    loadDataMember(currentUser.Email);
                }
            }
        }

        protected void loadDataAdmin()
        {
            GridView1.DataSource = TransactionController.getAllTransaction();
            GridView1.DataBind();
        }

        void loadDataMember(String email)
        {
            GridView1.DataSource = TransactionController.getTransactionByEmail(email);
            GridView1.DataBind();
        }

        protected void btnGenerateTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReport.aspx");
        }
    }
}