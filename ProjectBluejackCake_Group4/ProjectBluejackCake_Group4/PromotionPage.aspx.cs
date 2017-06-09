using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class PromotionPage : System.Web.UI.Page
    {
        void loadData()
        {
            viewPromotion.DataSource = PromotionRepositories.getAllPromo();
            viewPromotion.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Member currUser = (Member)Session["userLogin"];

            if (Session["userLogin"] == null )
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

        protected void viewPromotion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String promoTitle = viewPromotion.Rows[e.RowIndex].Cells[0].Text;

            Promotion x = PromotionRepositories.getPromo(promoTitle);

            int row = PromotionRepositories.deletePromot(x);

            lblErrProm.Text = "Deletion Success!";

            if (row > 0)
            {
                loadData();
            }
        }

        protected void btnAddPromotion_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPromotion.aspx");
        }

        protected void viewPromotion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String promoTitle = viewPromotion.Rows[e.RowIndex].Cells[0].Text;

            Response.Redirect(String.Format("UpdatePromotion.aspx?promoTitle={0}", promoTitle));
        }
    }
}