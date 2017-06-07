using ProjectBluejackCake_Group4.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Promotion> x = PromotionController.getAll();



            lblTitle.Text = x.Last().Title;
            lblDesc.Text = x.Last().Description;
            lblDiscount.Text = x.Last().Discount.ToString();
        }
    }
}