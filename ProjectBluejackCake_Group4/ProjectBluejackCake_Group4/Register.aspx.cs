using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] != null) Response.Redirect("Home.aspx");
        }

        static bool checkEmail(String email)
        {
            if (email.Split('@').Length != 2) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") - 1) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") + 1) return false;
            return true;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String cPassword = txtConfirmPassword.Text;
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            System.DateTime dob;

            Member member = MemberRepositories.findEmail(email);

            erMessage.Text = "";
            erMessage.ForeColor = System.Drawing.Color.Red;

            if (member == null)
            {
                if (!DateTime.TryParse(txtDOB.Text, out dob)) erMessage.Text = "Wrong input of DOB";
                else if (name == "") erMessage.Text = "Name Must Not Empty";
                else if (email == "") erMessage.Text = "Email Must Not Empty";
                else if (checkEmail(email) == false) erMessage.Text = "Wrong Email Format";
                else if (password == "") erMessage.Text = "Password Must Not Empty";
                else if (cPassword != password) erMessage.Text = "Password Not Match";
                else if (phone == "") erMessage.Text = "Phone Must Not Empty";
                else if (address == "") erMessage.Text = "Address Must Not Empty";
                else
                {
                    Member m = Factory.MemberFactory.create(name, email, password, dob, phone, address);
                    int row = MemberRepositories.register(m);
                    if (row > 0)
                    {
                        erMessage.ForeColor = System.Drawing.Color.Blue;
                        erMessage.Text = "Register Success";
                    }
                    else
                    {
                        erMessage.Text = "Register Failed";
                    }
                }
            }
            else
            {
                erMessage.Text = "Email Already Taken";
            }

        }
    }
}