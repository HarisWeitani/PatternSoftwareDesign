using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class ViewCustomer : System.Web.UI.Page
    {

        void loadData()
        {
            viewCustomerGrid.DataSource = MemberRepositories.getAllMemberOnly();
            viewCustomerGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Member currUser = (Member)Session["userLogin"];

            if (Session["userLogin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else if (currUser.Type == "Customer")
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                loadData();
            }
        }

        protected void viewCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String memberEmail = viewCustomerGrid.Rows[e.RowIndex].Cells[1].Text;

            Member x = MemberRepositories.findEmail(memberEmail);

            int row = MemberRepositories.deleteMember(x);

            lblErr.Text = "Deletion Success!";

            if (row > 0)
            {
                loadData();
            }
        }
    }
}