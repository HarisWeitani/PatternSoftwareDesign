using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null) Response.Redirect("Login.aspx"); 
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["userLogin"];

            erMessage.Text = "";
            erMessage.ForeColor = System.Drawing.Color.Red;

            if (txtOldPassword.Text == "") erMessage.Text = "Old Password Must Not Empty";
            else if (txtNewPassword.Text == "") erMessage.Text = "New Password Must Not Empty";
            else if (txtConfirmPassword.Text == "") erMessage.Text = "Confirm Password Must Not Empty";
            else if (txtOldPassword.Text != currentUser.Password) erMessage.Text = "Wrong Old Password";
            else if (txtConfirmPassword.Text != txtNewPassword.Text) erMessage.Text = "Password Not Match";
            else
            {
                List<Member> m = MemberRepositories.getAllMember(currentUser.Email);
                int row = MemberRepositories.updateMember(m, txtNewPassword.Text);

                erMessage.ForeColor = System.Drawing.Color.Green;
                erMessage.Text = "Change Password Success";
            }


        }
    }
}