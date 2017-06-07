using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("Login.aspx");
            } 

            Member currUser = (Member)Session["userLogin"];

            lblName.Text = currUser.Name;
            lblEmail.Text = currUser.Email;
            lblDOB.Text = currUser.DOB.ToString();
            lblPhone.Text = currUser.PhoneNumber;
            lblAddress.Text = currUser.Address;
        }
    }
}