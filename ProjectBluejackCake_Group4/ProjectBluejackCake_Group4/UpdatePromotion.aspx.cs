using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class UpdatePromotion : System.Web.UI.Page
    {

        void loadData()
        {
            viewUpdatePromo.DataSource = PromotionRepositories.getAllPromo();
            viewUpdatePromo.DataBind();
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

        protected void btnUpdatePromotion_Click(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            String descrption = txtDescription.Text;
            int discount = Int32.Parse(txtDiscount.Text);

            List<Promotion> x = PromotionRepositories.getAllPromoByTitle(title);

            if (x == null)
            {
                erMessage.Text = "Cake doesn't exist!";
            }

            else
            {
                int row = PromotionRepositories.updatePromo(x, title, descrption, discount);
                loadData();
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("PromotionPage.aspx");
        }
    }
}