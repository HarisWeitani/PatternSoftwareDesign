using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Member member = MemberRepositories.findEmail(txtEmail.Text);

            erMessage.Text = "";
            erMessage.ForeColor = System.Drawing.Color.Red;

            if (member == null) erMessage.Text = "Email Not Found";
            else
            {
                string name = member.Name;
                string newPassword;

                const string alphabet = "abcdefghijklmnopqrstuvwxyz";

                Random rand = new Random((int)DateTime.Now.Ticks);

                string number1 = rand.Next(0, 9).ToString();
                string number2 = rand.Next(0, 9).ToString();
                string char1 = alphabet.Substring(rand.Next(0, alphabet.Length - 1), 1);
                string char2 = alphabet.Substring(rand.Next(0, alphabet.Length - 1), 1);
                string cutName = name.Substring(0, 2);

                newPassword = number1 + number2 + char1 + char2 + cutName;

                erMessage.ForeColor = System.Drawing.Color.Green;
                erMessage.Text = "Your New Password : " + newPassword;

                List<Member> m = MemberRepositories.getAllMember(txtEmail.Text);
                int row = MemberRepositories.updateMember(m, newPassword);

            }

        }
    }
}