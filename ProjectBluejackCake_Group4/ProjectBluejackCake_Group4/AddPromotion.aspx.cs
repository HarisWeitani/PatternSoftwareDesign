using ProjectBluejackCake_Group4.Factory;
using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class AddPromotion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPromotion_Click(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            String description = txtDescription.Text;
            int discount = Int32.Parse(txtDiscount.Text);

            Promotion x = PromotionFactory.create(title, description, discount);
            PromotionRepositories.insertPromo(x);

            erMessage.Text = "Successfully added new Promotion!";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Promotion.aspx");
        }
    }
}