using ProjectBluejackCake_Group4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectBluejackCake_Group4
{
    public partial class UpdateCake : System.Web.UI.Page
    {
        Cake editCake;

        void loadData()
        {
            viewUpdateCake.DataSource = CakeRepositories.getAllCake();
            viewUpdateCake.DataBind();
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

                string cakeName = Request.QueryString["cakeName"];

                if (cakeName != null)
                {
                    editCake = Handler.CakeHandler.get(cakeName);

                    if (editCake != null) //check if cake exists
                    {
                        if (!Page.IsPostBack)
                        {
                            txtCakeName.Text = editCake.CakeName;
                            txtCakePrice.Text = Convert.ToString(editCake.Price);
                            txtCakeStock.Text = Convert.ToString(editCake.Stock);
                        }
                    }
                }
            }
        }

        protected void btnUpdateCake_Click(object sender, EventArgs e)
        {
            String picExt;
            String cakePic;

            Cake cake = Handler.CakeHandler.get(txtCakeName.Text);

            if (editCake == null) erMessage.Text = "Cake Does Not Exist";
            else
            {
                if (txtCakeName.Text == "") erMessage.Text = "Input Cake Name";
                else if (txtCakeName.Text != editCake.CakeName && cake != null) erMessage.Text = "Cake Name Already Exist";
                else if (txtCakePrice.Text == "") erMessage.Text = "Cake Price Must Not Empty";
                else if (txtCakeStock.Text == "") erMessage.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else if (Int32.Parse(txtCakeStock.Text) <= 0) erMessage.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else
                {
                    if (this.uplCakePicture.HasFile)
                    {
                        //picExt = uploadPicture.FileName.Substring(uploadPicture.FileName.Length - 4);

                        picExt = System.IO.Path.GetExtension(uplCakePicture.FileName).ToLower();

                        if (picExt == ".jpg" || picExt == ".png")
                        {
                            this.uplCakePicture.SaveAs(Server.MapPath("~/") + txtCakeName.Text + picExt);
                            cakePic = txtCakeName.Text + picExt;

                            string cakeName = txtCakeName.Text;
                            int cakePrice = Int32.Parse(txtCakePrice.Text);
                            int cakeStock = Int32.Parse(txtCakeStock.Text);

                            List<Cake> c = Handler.CakeHandler.getAllCake(editCake.CakeName);
                            int row = CakeRepositories.updateCake(c, cakeName, cakePrice, cakeStock, cakePic);

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

                        List<Cake> c = Handler.CakeHandler.getAllCake(editCake.CakeName);
                        int row = CakeRepositories.updateCake(c, cakeName, cakePrice, cakeStock, cakePic);
                    }

                    Response.Redirect("Cake_Page.aspx");
                }
            }




        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cake_Page.aspx");
        }
    }
}