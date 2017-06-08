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
            Member currUser = (Member)Session["userLogin"];

            if (Session["userLogin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else if (currUser.Type == "Customer")
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            string picExt;
            string cakePic;

            Cake cake = Handler.CakeHandler.get(txtCakeName.Text);

            if (cake == null)
            {

                if (txtCakeName.Text == "") erMessage.Text = "Input Cake Name";
                else if (txtCakePrice.Text == "") erMessage.Text = "Cake Price Must Not Empty";
                else if (txtCakeStock.Text == "") erMessage.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else if (Int32.Parse(txtCakeStock.Text) <= 0) erMessage.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else
                {
                    if (this.uplCakePicture.HasFile)
                    {
                        picExt = uplCakePicture.FileName.Substring(uplCakePicture.FileName.Length - 4);
                        if (picExt == ".jpg" || picExt == ".png")
                        {
                            this.uplCakePicture.SaveAs(Server.MapPath("~/") + txtCakeName.Text + picExt);
                            cakePic = txtCakeName.Text + picExt;

                            string cakeName = txtCakeName.Text;
                            int cakePrice = Int32.Parse(txtCakePrice.Text);
                            int cakeStock = Int32.Parse(txtCakeStock.Text);

                            Cake c = CakeFactory.create(cakeName, cakePrice, cakeStock, cakePic);
                            int row = Repositories.CakeRepositories.insertCake(c);

                            if (row > 0)
                            {
                                erMessage.ForeColor = System.Drawing.Color.Blue;
                                erMessage.Text = "Add Cake Success";
                            }
                            else
                            {
                                erMessage.Text = "Add Cake Failed";
                            }
                        }
                        else
                        {
                            erMessage.Text = "Image Ekstension Must be .jpg or .png";
                        }
                    }
                    else
                    {
                        string cakeName = txtCakeName.Text;
                        int cakePrice = Int32.Parse(txtCakePrice.Text);
                        int cakeStock = Int32.Parse(txtCakeStock.Text);
                        cakePic = null;

                        Cake c = CakeFactory.create(cakeName, cakePrice, cakeStock, cakePic);
                        int row = Repositories.CakeRepositories.insertCake(c);

                        if (row > 0)
                        {
                            erMessage.ForeColor = System.Drawing.Color.Blue;
                            erMessage.Text = "Add Cake Success, No Picture Added";
                        }
                        else
                        {
                            erMessage.Text = "Add Cake Failed";
                        }
                    }

                }
            }
            else
            {
                erMessage.Text = "Cake Name Already Exist";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cake_Page.aspx");
        }
    }
}