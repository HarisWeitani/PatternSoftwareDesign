using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kalo dia load, langsung load time juga
            lblDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:sstt");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:sstt");
        }
    }
}