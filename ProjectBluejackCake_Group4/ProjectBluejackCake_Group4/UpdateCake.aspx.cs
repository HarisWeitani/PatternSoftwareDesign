//using ProjectBluejackCake_Group4.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace ProjectBluejackCake_Group4
//{
//    public partial class UpdateCake : System.Web.UI.Page
//    {
//        void loadData()
//        {
//            viewUpdateCake.DataSource = CakeRepositories.getAllCake();
//            viewUpdateCake.DataBind();
//        }

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            loadData();
//        }

//        protected void btnUpdateCake_Click(object sender, EventArgs e)
//        {
//            String Cake_Name = txtCakeName.Text;
//            int Cake_Price = Int32.Parse(txtCakePrice.Text);
//            int Cake_Stock = Int32.Parse(txtCakeStock.Text);
//            String Cake_Picture = uplCakePicture.ToString();

//            List<Cake> c = CakeRepositories.getAllCakeByName(Cake_Name);

//            if(c == null)
//            {
//                erMessage.Text = "Cake doestn't exist";
//            }
//            else
//            {
//                int row = CakeRepositories.updateCake(c, Cake_Name, Cake_Price, Cake_Stock, Cake_Picture);
//                loadData();
//            }

//        }

//        protected void btnBack_Click(object sender, EventArgs e)
//        {
//            Response.Redirect("Cake.aspx");
//        }
//    }
//}