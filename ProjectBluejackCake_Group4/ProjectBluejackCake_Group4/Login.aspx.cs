using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Session["userLogin"] != null)
                {
                    Response.Redirect("Home.aspx");
                }
                if(Request.Cookies["userCookies"] != null)
                {
                    txtEmail.Text = Request.Cookies["userCookies"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Member member = MemberRepositories.LoginUser(txtEmail.Text, txtPassword.Text);

            erMessage.Text = "";
            erMessage.ForeColor = System.Drawing.Color.Red;

            if(member == null)
            {
                erMessage.Text = "User Not Found";
            }
            else
            {
                if (ckRemember.Checked)
                {
                    Response.Cookies["userCookies"].Expires = DateTime.Now.AddHours(1);
                }
                else
                {
                    Response.Cookies["userCookies"].Expires = DateTime.Now.AddHours(-1);
                }
                Response.Cookies["userCookies"].Value = txtEmail.Text;

                Session["userLogin"] = member;

                Response.Redirect("Home.aspx");

            }

        }
    }
}