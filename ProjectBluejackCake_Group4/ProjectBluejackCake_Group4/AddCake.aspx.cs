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
    public partial class AddCake : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            String Cake_Name = txtCakeName.Text;
            int Cake_Price = Int32.Parse(txtCakePrice.Text);
            int Cake_Stock = Int32.Parse(txtCakeStock.Text);
            String Cake_Picture = uplCakePicture.ToString();

            Cake c = CakeFactory.create(Cake_Name, Cake_Price, Cake_Stock, Cake_Picture);
            CakeRepositories.insertCake(c);

            erMessage.Text = "Successfully added new Cake!";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cake.aspx");
        }
    }
}