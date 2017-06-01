using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["userLogin"];
            if (currentUser == null)
            {
                Response.Redirect("Home.aspx");
            }
            else if (currentUser != null)
            {
                
                if (currentUser.Type == "Admin")
                {
                    
                }
                else if (currentUser.Type == "Customer")
                {
                    
                }
            }
        }
    }
}