using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Cake : System.Web.UI.Page
    {
        void loadData()
        {
            ViewAllCake.DataSource = CakeRepositories.getAllCake();
            ViewAllCake.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCake.aspx");
        }

        protected void btnUpdateCake_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCake.aspx");
        }

        protected void ViewAllCake_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String Cake_Name = ViewAllCake.Rows[e.RowIndex].Cells[0].Text;
            Cake c = CakeRepositories.getCake(Cake_Name);
            int row = CakeRepositories.deleteCake(c);
            lblError.Text = "Deletion Success!";
            if (row > 0)
            {
                loadData();
            }
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}